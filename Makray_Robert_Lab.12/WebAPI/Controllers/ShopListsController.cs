#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ShopListsController : Controller
    {
        private readonly WebAPIContext _context;

        public ShopListsController(WebAPIContext context)
        {
            _context = context;
        }

        // GET: ShopLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShopList.ToListAsync());
        }

        // GET: ShopLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopList = await _context.ShopList
                .FirstOrDefaultAsync(m => m.ID == id);
            if (shopList == null)
            {
                return NotFound();
            }

            return View(shopList);
        }

        // GET: ShopLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShopLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Description,Date")] ShopList shopList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopList);
        }

        // GET: ShopLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopList = await _context.ShopList.FindAsync(id);
            if (shopList == null)
            {
                return NotFound();
            }
            return View(shopList);
        }

        // POST: ShopLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description,Date")] ShopList shopList)
        {
            if (id != shopList.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopListExists(shopList.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(shopList);
        }

        // GET: ShopLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopList = await _context.ShopList
                .FirstOrDefaultAsync(m => m.ID == id);
            if (shopList == null)
            {
                return NotFound();
            }

            return View(shopList);
        }

        // POST: ShopLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopList = await _context.ShopList.FindAsync(id);
            _context.ShopList.Remove(shopList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopListExists(int id)
        {
            return _context.ShopList.Any(e => e.ID == id);
        }
    }
}
