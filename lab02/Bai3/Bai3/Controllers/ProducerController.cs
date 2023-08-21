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
    public class ProducerController : Controller
    {
        private readonly Bai3Context _context;

        public ProducerController(Bai3Context context)
        {
            _context = context;
        }

        // GET: Producer
        public async Task<IActionResult> Index()
        {
              return _context.ProducerModel != null ? 
                          View(await _context.ProducerModel.ToListAsync()) :
                          Problem("Entity set 'Bai3Context.ProducerModel'  is null.");
        }

        // GET: Producer/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.ProducerModel == null)
            {
                return NotFound();
            }

            var producerModel = await _context.ProducerModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producerModel == null)
            {
                return NotFound();
            }

            return View(producerModel);
        }

        // GET: Producer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ProducerModel producerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producerModel);
        }

        // GET: Producer/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.ProducerModel == null)
            {
                return NotFound();
            }

            var producerModel = await _context.ProducerModel.FindAsync(id);
            if (producerModel == null)
            {
                return NotFound();
            }
            return View(producerModel);
        }

        // POST: Producer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name")] ProducerModel producerModel)
        {
            if (id != producerModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProducerModelExists(producerModel.Id))
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
            return View(producerModel);
        }

        // GET: Producer/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.ProducerModel == null)
            {
                return NotFound();
            }

            var producerModel = await _context.ProducerModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producerModel == null)
            {
                return NotFound();
            }

            return View(producerModel);
        }

        // POST: Producer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.ProducerModel == null)
            {
                return Problem("Entity set 'Bai3Context.ProducerModel'  is null.");
            }
            var producerModel = await _context.ProducerModel.FindAsync(id);
            if (producerModel != null)
            {
                _context.ProducerModel.Remove(producerModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProducerModelExists(string id)
        {
          return (_context.ProducerModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
