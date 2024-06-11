using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthAppAdminPortal.Data;
using HealthAppAdminPortal.Models;

namespace HealthAppAdminPortal.Controllers
{
    public class NotificationIntervalsController : Controller
    {
        private readonly DataContext _context;

        public NotificationIntervalsController(DataContext context)
        {
            _context = context;
        }

        //Not Needed
        //// GET: NotificationIntervals
        //public async Task<IActionResult> Index()
        //{
        //      return _context.NotificationIntervals != null ? 
        //                  View(await _context.NotificationIntervals.ToListAsync()) :
        //                  Problem("Entity set 'DataContext.NotificationIntervals'  is null.");
        //}

        //// GET: NotificationIntervals/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.NotificationIntervals == null)
        //    {
        //        return NotFound();
        //    }

        //    var notificationInterval = await _context.NotificationIntervals
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (notificationInterval == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(notificationInterval);
        //}

        //// GET: NotificationIntervals/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: NotificationIntervals/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,IntervalTime")] NotificationInterval notificationInterval)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(notificationInterval);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(notificationInterval);
        //}

        // GET: NotificationIntervals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NotificationIntervals == null)
            {
                return NotFound();
            }

            var notificationInterval = await _context.NotificationIntervals.FindAsync(id);
            if (notificationInterval == null)
            {
                return NotFound();
            }
            return View(notificationInterval);
        }

        // POST: NotificationIntervals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IntervalTime")] NotificationInterval notificationInterval)
        {
            if (id != notificationInterval.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notificationInterval);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotificationIntervalExists(notificationInterval.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), nameof(Notification));
            }
            return RedirectToAction(nameof(Index),nameof(Notification));
        }

        //// GET: NotificationIntervals/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.NotificationIntervals == null)
        //    {
        //        return NotFound();
        //    }

        //    var notificationInterval = await _context.NotificationIntervals
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (notificationInterval == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(notificationInterval);
        //}

        //// POST: NotificationIntervals/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.NotificationIntervals == null)
        //    {
        //        return Problem("Entity set 'DataContext.NotificationIntervals'  is null.");
        //    }
        //    var notificationInterval = await _context.NotificationIntervals.FindAsync(id);
        //    if (notificationInterval != null)
        //    {
        //        _context.NotificationIntervals.Remove(notificationInterval);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool NotificationIntervalExists(int id)
        {
          return (_context.NotificationIntervals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
