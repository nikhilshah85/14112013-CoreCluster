using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCore_CodeFirst.Models;

namespace EFCore_CodeFirst.Controllers
{
    public class deptInfoesController : Controller
    {
        private readonly EmployeeManagementDBContext _context;

        public deptInfoesController(EmployeeManagementDBContext context)
        {
            _context = context;
        }

        // GET: deptInfoes
        public async Task<IActionResult> Index()
        {
              return _context.DepartmentInfo != null ? 
                          View(await _context.DepartmentInfo.ToListAsync()) :
                          Problem("Entity set 'EmployeeManagementDBContext.DepartmentInfo'  is null.");
        }

        // GET: deptInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DepartmentInfo == null)
            {
                return NotFound();
            }

            var deptInfo = await _context.DepartmentInfo
                .FirstOrDefaultAsync(m => m.deptNo == id);
            if (deptInfo == null)
            {
                return NotFound();
            }

            return View(deptInfo);
        }

        // GET: deptInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: deptInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("deptNo,deptName,deptLocation")] deptInfo deptInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deptInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deptInfo);
        }

        // GET: deptInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DepartmentInfo == null)
            {
                return NotFound();
            }

            var deptInfo = await _context.DepartmentInfo.FindAsync(id);
            if (deptInfo == null)
            {
                return NotFound();
            }
            return View(deptInfo);
        }

        // POST: deptInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("deptNo,deptName,deptLocation")] deptInfo deptInfo)
        {
            if (id != deptInfo.deptNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deptInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!deptInfoExists(deptInfo.deptNo))
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
            return View(deptInfo);
        }

        // GET: deptInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DepartmentInfo == null)
            {
                return NotFound();
            }

            var deptInfo = await _context.DepartmentInfo
                .FirstOrDefaultAsync(m => m.deptNo == id);
            if (deptInfo == null)
            {
                return NotFound();
            }

            return View(deptInfo);
        }

        // POST: deptInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DepartmentInfo == null)
            {
                return Problem("Entity set 'EmployeeManagementDBContext.DepartmentInfo'  is null.");
            }
            var deptInfo = await _context.DepartmentInfo.FindAsync(id);
            if (deptInfo != null)
            {
                _context.DepartmentInfo.Remove(deptInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool deptInfoExists(int id)
        {
          return (_context.DepartmentInfo?.Any(e => e.deptNo == id)).GetValueOrDefault();
        }
    }
}
