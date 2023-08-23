using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagerProject.Data;

namespace MovieApp.Controllers
{
    public class ProducersController : Controller
    {
        //Used to instantiate the database for dependency injection.
        private readonly AppDbContext _context;

        //Allows controller to access the database and perform CRUD operations.
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        //IActionResult indicates that the method returns a result that is used to render the HTML view.
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
