using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicket.Data;
using eTicket.Data.Services;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        ///public async Task<IActionResult> Create([Bind("FullName, ProfilePictureUrl, Bio")] Actor actor)
        public async Task<IActionResult> Create([Bind()] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));

        }

        //Get: Actors/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        // Get: Actors/Edit/1 
        public async Task <IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
           
        }

        [HttpPost]
        ///public async Task<IActionResult> Create([Bind("FullName, ProfilePictureUrl, Bio")] Actor actor)
        public async Task<IActionResult> Edit(int id,[Bind()] Actor actor)
        {  
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id, actor); 
            return RedirectToAction(nameof(Index));

        }

        // Get: Actors/Delete/1 
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
             
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);

        } 
         
        [HttpPost, ActionName("Delete")]
        ///public async Task<IActionResult> Create([Bind("FullName, ProfilePictureU rl, Bio")] Actor actor)
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));


             

        }

    }
}
