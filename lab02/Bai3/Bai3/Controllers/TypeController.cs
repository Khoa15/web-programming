using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bai3.Data;
using Bai3.Models;

namespace Bai3.Controllers
{
    public class TypeController : Controller
    {
        private readonly Bai3Context _context;

        public TypeController(Bai3Context context)
        {
            _context = context;
        }

        // GET: Type
        public async Task<IActionResult> Index()
        {
              return _context.TypeModel != null ? 
                          View(await _context.TypeModel.ToListAsync()) :
                          Problem("Entity set 'Bai3Context.TypeModel'  is null.");
        }

        // GET: Type/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TypeModel == null)
            {
                return NotFound();
            }

            var typeModel = await _context.TypeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeModel == null)
            {
                return NotFound();
            }

            return View(typeModel);
        }

        // GET: Type/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] TypeModel typeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeModel);
        }

        // GET: Type/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TypeModel == null)
            {
                return NotFound();
            }

            var typeModel = await _context.TypeModel.FindAsync(id);
            if (typeModel == null)
            {
                return NotFound();
            }
            return View(typeModel);
        }

        // POST: Type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name")] TypeModel typeModel)
        {
            if (id != typeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeModelExists(typeModel.Id))
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
            return View(typeModel);
        }

        // GET: Type/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TypeModel == null)
            {
                return NotFound();
            }

            var typeModel = await _context.TypeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeModel == null)
            {
                return NotFound();
            }

            return View(typeModel);
        }

        // POST: Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.TypeModel == null)
            {
                return Problem("Entity set 'Bai3Context.TypeModel'  is null.");
            }
            var typeModel = await _context.TypeModel.FindAsync(id);
            if (typeModel != null)
            {
                _context.TypeModel.Remove(typeModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeModelExists(string id)
        {
          return (_context.TypeModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
