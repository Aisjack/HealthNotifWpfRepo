using HealthAppAdminPortal.Data;
using HealthAppAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HealthAppAdminPortal.Controllers
{
    public class NotificationController : Controller
    {
        private readonly DataContext _context;
        public NotificationController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.Notifications.ToList();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, NotificationText, NotificationUrl, UrlActive")] Notification notification)
        {
            try
            {
                _context.Add(notification);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Notification");
            }
            catch
            {
                return View(notification);
            }

        }

        public IActionResult Edit(int Id)
        {
            var result = _context.Notifications.Where(x => x.Id == Id).FirstOrDefault();
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("Id, NotificationText, NotificationUrl, UrlActive")] Notification notification)
        {
            if (Id != notification.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!notificationExists(notification.Id))
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
            return View(notification);

        }

        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _context.Notifications.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (result != null)
            {
                _context.Notifications.Remove(result);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Notification");
        }

        private bool notificationExists(int id)
        {
            return (_context.Notifications?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
