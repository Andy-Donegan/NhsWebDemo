#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NhsWebDemo.DataContext;
using NhsWebDemo.Models;

namespace NhsWebDemo.Controllers
{
    public class LocalUserModelsController : Controller
    {
        private readonly LocalDBContext _context;

        public LocalUserModelsController(LocalDBContext context)
        {
            _context = context;
        }

        // GET: LocalUserModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.LocalUserModels.ToListAsync());
        }

        // GET: LocalUserModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localUserModel = await _context.LocalUserModels
                .FirstOrDefaultAsync(m => m.iD == id);
            if (localUserModel == null)
            {
                return NotFound();
            }

            return View(localUserModel);
        }

        // GET: LocalUserModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LocalUserModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("iD,name,organisation,dailyAppointments,dailyAttended,dailyCancelled,dailyNonCompliance,dailyLate,dailySafetyAlerts,dailyMissingData,weeklyAppointments,weeklyAttended,weeklyCancelled,weeklyNonCompliance,weeklyLate,weeklySafetyAlerts,weeklyMissingData,monthlyAppointments,monthlyAttended,monthlyCancelled,monthlyNonCompliance,monthlyLate,monthlySafetyAlerts,monthlyMissingData")] LocalUserModel localUserModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localUserModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(localUserModel);
        }

        // GET: LocalUserModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localUserModel = await _context.LocalUserModels.FindAsync(id);
            if (localUserModel == null)
            {
                return NotFound();
            }
            return View(localUserModel);
        }

        // POST: LocalUserModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("iD,name,organisation,dailyAppointments,dailyAttended,dailyCancelled,dailyNonCompliance,dailyLate,dailySafetyAlerts,dailyMissingData,weeklyAppointments,weeklyAttended,weeklyCancelled,weeklyNonCompliance,weeklyLate,weeklySafetyAlerts,weeklyMissingData,monthlyAppointments,monthlyAttended,monthlyCancelled,monthlyNonCompliance,monthlyLate,monthlySafetyAlerts,monthlyMissingData")] LocalUserModel localUserModel)
        {
            if (id != localUserModel.iD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localUserModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalUserModelExists(localUserModel.iD))
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
            return View(localUserModel);
        }

        // GET: LocalUserModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localUserModel = await _context.LocalUserModels
                .FirstOrDefaultAsync(m => m.iD == id);
            if (localUserModel == null)
            {
                return NotFound();
            }

            return View(localUserModel);
        }

        // POST: LocalUserModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var localUserModel = await _context.LocalUserModels.FindAsync(id);
            _context.LocalUserModels.Remove(localUserModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalUserModelExists(int id)
        {
            return _context.LocalUserModels.Any(e => e.iD == id);
        }
    }
}
