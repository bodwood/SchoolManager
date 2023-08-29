using SchoolManagerProject.Data;
using SchoolManagerProject.Data.Services;
using SchoolManagerProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerProject.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        //HttpPost: Cinemas/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, Logo, Bio")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cinemas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
                return View("NotFound");
            return View(cinemaDetails);
        }

        //Get: Cinemas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
                return View("NotFound");
            return View(cinemaDetails);
        }

        //HttpPost: Cinemas/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, Logo,Bio")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cinemas/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null)
                return View("NotFound");
            return View(cinemaDetails);
        }

        //HttpPost: Cinemas/Delete/1
        [HttpPost]
        public async Task<IActionResult> Delete(int id, Cinema cinema)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
