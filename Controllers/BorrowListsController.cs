using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HyperDuckLibrary.Data;
using HyperDuckLibrary.Models;

namespace HyperDuckLibrary.Controllers
{
    public class BorrowListsController : Controller
    {
        private readonly HyperDuckLibraryContext _context;

        public BorrowListsController(HyperDuckLibraryContext context)
        {
            _context = context;
        }

        // GET: BorrowLists
        public async Task<IActionResult> Index()
        {
            var hyperDuckLibraryContext = _context.BorrowList.Include(b => b.Books).Include(b => b.Customers);
            return View(await hyperDuckLibraryContext.ToListAsync());
        }

        // GET: BorrowLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BorrowList == null)
            {
                return NotFound();
            }

            var borrowList = await _context.BorrowList
                .Include(b => b.Books)
                .Include(b => b.Customers)
                .FirstOrDefaultAsync(m => m.BorrowId == id);
            if (borrowList == null)
            {
                return NotFound();
            }

            return View(borrowList);
        }

        // GET: BorrowLists/Create
        public IActionResult Create()
        {
            ViewData["Fk_BookId"] = new SelectList(_context.Book, "BookId", "BookName");
            ViewData["Fk_CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FullName");
            return View();
        }

        // POST: BorrowLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BorrowId,Fk_BookId,Fk_CustomerId,BorrowedDate,DueDate,IsReturned")] BorrowList borrowList)
        {
            if (ModelState.IsValid)
            {
                if (borrowList.BorrowedDate.HasValue)
                {
                    borrowList.DueDate = borrowList.BorrowedDate.Value.AddDays(28);
                }
                if (borrowList.IsReturned == null)
                {
                    borrowList.IsReturned = false;
                }
                _context.Add(borrowList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
    
            ViewData["Fk_BookId"] = new SelectList(_context.Book, "BookId", "BookName", borrowList.Fk_BookId);
            ViewData["Fk_CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FullName", borrowList.Fk_CustomerId);
            return View(borrowList);
        }

        // GET: BorrowLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BorrowList == null)
            {
                return NotFound();
            }

            var borrowList = await _context.BorrowList.FindAsync(id);
            if (borrowList == null)
            {
                return NotFound();
            }
            ViewData["Fk_BookId"] = new SelectList(_context.Book, "BookId", "BookName", borrowList.Fk_BookId);
            ViewData["Fk_CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FullName", borrowList.Fk_CustomerId);
            return View(borrowList);
        }

        // POST: BorrowLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BorrowId,Fk_BookId,Fk_CustomerId,BorrowedDate,DueDate,IsReturned")] BorrowList borrowList)
        {
            if (id != borrowList.BorrowId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borrowList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BorrowListExists(borrowList.BorrowId))
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
            ViewData["Fk_BookId"] = new SelectList(_context.Book, "BookId", "Author", borrowList.Fk_BookId);
            ViewData["Fk_CustomerId"] = new SelectList(_context.Customer, "CustomerId", "Email", borrowList.Fk_CustomerId);
            return View(borrowList);
        }

        // GET: BorrowLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BorrowList == null)
            {
                return NotFound();
            }

            var borrowList = await _context.BorrowList
                .Include(b => b.Books)
                .Include(b => b.Customers)
                .FirstOrDefaultAsync(m => m.BorrowId == id);
            if (borrowList == null)
            {
                return NotFound();
            }

            return View(borrowList);
        }

        // POST: BorrowLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BorrowList == null)
            {
                return Problem("Entity set 'HyperDuckLibraryContext.BorrowList'  is null.");
            }
            var borrowList = await _context.BorrowList.FindAsync(id);
            if (borrowList != null)
            {
                _context.BorrowList.Remove(borrowList);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BorrowListExists(int id)
        {
            return (_context.BorrowList?.Any(e => e.BorrowId == id)).GetValueOrDefault();
        }
    }
}
