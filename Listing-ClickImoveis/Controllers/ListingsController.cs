using System.Threading.Tasks;
using Listing_ClickImoveis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Listing_ClickImoveis.Controllers
{
    public class ListingsController : Controller
    {
        private readonly AppDbContext _context;

        public ListingsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Listings.ToListAsync();
            return View(dados); 
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Listing listing)
        {

            if (ModelState.IsValid)
            {
                _context.Listings.Add(listing);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(listing);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Listings.FindAsync(id);

            if (dados == null)
                return NotFound();
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Listing listing)
        {
            if (id != listing.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Listings.Update(listing);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return View();
        }

       
        }
    }

