using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagerProject.Data;
using SchoolManagerProject.Data.Services;
using SchoolManagerProject.Models;

namespace SchoolManagerProject.Controllers
{
    public class ProducersController : Controller
    {
        //Used to instantiate the database for dependency injection.
        private readonly IProducersService _service;

        //Allows controller to access the database and perform CRUD operations.
        public ProducersController(IProducersService service)
        {
            _service = service;
        }

        //IActionResult indicates that the method returns a result that is used to render the HTML view.
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        //POST: producers/create
        [HttpPost]
        public async Task<IActionResult> Create(
            [Bind("FirstName, LastName, ProfilePicture, Bio")] Producer producer
        )
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //GET: producers/details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null)
                return View("NotFound");
            return View(producerDetails);
        }

        //GET: producers/edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
                return View("NotFound");
            return View(producerDetails);
        }

        //POST: producers/edit/{id}
        [HttpPost]
        public async Task<IActionResult> Edit(
            int id,
            [Bind("Id, FirstName, LastName, ProfilePicture, Bio")] Producer producer
        )
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));
        }

        //GET: producers/delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
                return View("NotFound");
            return View(producerDetails);
        }

        //POST: producers/delete/{id}
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
                return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
