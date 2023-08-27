using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolManagerProject.Data;
using SchoolManagerProject.Data.Services;
using SchoolManagerProject.Models;

namespace SchoolManagerProject.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [Bind("FirstName, LastName, ProfilePicture, Bio")] Actor actor
        )
        {
            //Return view with model state errors if model state is invalid.
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            //Add actor to database and redirect to index.
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("Empty");
            }
            return View(actorDetails);
        }

        //Get: Actors/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("Empty");
            }
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            //Return view with model state errors if model state is invalid.
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            //Add actor to database and redirect to index.
            await _service.UpdateAsync(id, actor);

            //Return to details page.
            var actorDetails = await _service.GetByIdAsync(id);
            return RedirectToAction(nameof(Details), new { id = id });
        }

        //Get: Actors/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("Not Found");
            }
            return View(actorDetails);
        }

        //Delete: Actors/Delete/{id}
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("Not Found");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
