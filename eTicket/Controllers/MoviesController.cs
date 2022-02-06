using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eTicket.Controllers
{
    public class MoviesController : Controller
    {
        
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/   
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n => n.Cinema).ToListAsync();
            return View(allMovies);
        }
    }
}
