using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcommerceWeb.Context;

namespace EcommerceWeb.Models
{
    public class CarritoDeComprasController : Controller
    {
        private readonly WebDatabaseContext _context;

        public CarritoDeComprasController(WebDatabaseContext context)
        {
            _context = context;
        }

        // GET: CarritoDeCompras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carritos.ToListAsync());
        }

        // GET: CarritoDeCompras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carritoDeCompras = await _context.Carritos
                .FirstOrDefaultAsync(m => m.id == id);
            if (carritoDeCompras == null)
            {
                return NotFound();
            }

            return View(carritoDeCompras);
        }

        // GET: CarritoDeCompras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarritoDeCompras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] CarritoDeCompras carritoDeCompras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carritoDeCompras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carritoDeCompras);
        }

        // GET: CarritoDeCompras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carritoDeCompras = await _context.Carritos.FindAsync(id);
            if (carritoDeCompras == null)
            {
                return NotFound();
            }
            return View(carritoDeCompras);
        }

        // POST: CarritoDeCompras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] CarritoDeCompras carritoDeCompras)
        {
            if (id != carritoDeCompras.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carritoDeCompras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarritoDeComprasExists(carritoDeCompras.id))
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
            return View(carritoDeCompras);
        }

        // GET: CarritoDeCompras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carritoDeCompras = await _context.Carritos
                .FirstOrDefaultAsync(m => m.id == id);
            if (carritoDeCompras == null)
            {
                return NotFound();
            }

            return View(carritoDeCompras);
        }

        // POST: CarritoDeCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carritoDeCompras = await _context.Carritos.FindAsync(id);
            _context.Carritos.Remove(carritoDeCompras);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarritoDeComprasExists(int id)
        {
            return _context.Carritos.Any(e => e.id == id);
        }
    }
}
