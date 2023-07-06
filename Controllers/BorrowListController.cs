using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HyperDuckLibrary.Data;
using HyperDuckLibrary.Models;
using Microsoft.Build.ObjectModelRemoting;

namespace HyperDuckLibrary.Controllers
{
    public class BorrowListController : Controller
    {
        private readonly HyperDuckLibraryContext _context;

        public BorrowListController(HyperDuckLibraryContext context)
        {
            _context = context;
        }

  
        //public IQueryable<Book> GetBooksBorrowedByCustomer(int customerId)
        //{
        //    var borrowedBooks = from borrow in _context.BorrowList
        //                        where borrow.CustomerId == customerId
        //                        join book in _context.Book on borrow.BookId equals book.BookId
        //                        select book;

        //    return borrowedBooks;
        //}

        // GET: BorrowList
        public async Task<IActionResult> Index()
        {

            var hyperDuckLibraryContext =  _context.BorrowList
                .Include(b => b.Books)
                .Include(b => b.Customers)
                .AsNoTracking();

            var _bookList = from bList in _context.Book
                            select bList.BookName;
            ViewBag.SDropdown = new SelectList(_context.Book, "BookName", "Author");



            var _custList = from cust in _context.Customer
                            select cust.FirstMidName;
            ViewBag.SDropdown = new SelectList(_context.Customer, "FirstMidName", "LastName");






            return View(await hyperDuckLibraryContext.ToListAsync());
        }

        // GET: BorrowList/Details/5
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

        //GET: BorrowList/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Book, "BookId", "BookName");
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FirstMidName");
            return View();
        }

        // POST: BorrowList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BorrowId,BookId,CustomerId")] BorrowList borrowList)
        {
            if (borrowList != null)
            {
                _context.Add(borrowList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Fk_BookId"] = new SelectList(_context.Book, "BookId", "Author", borrowList.Fk_BookId);
            ViewData["Fk_CustomerId"] = new SelectList(_context.Customer, "CustomerId", "Email", borrowList.Fk_CustomerId);
            return View(borrowList);
        }

        // GET: BorrowList/Edit/5
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
            ViewData["Fk_CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FirstMidName", borrowList.Fk_CustomerId);
            return View(borrowList);


            //////////////////////

            //var _bookList = from bList in _context.Book
            //                select bList.BookName;
            //ViewBag.BDropdown = new SelectList(_context.Book, "BookId", "BookName");
            ////ViewBag.BDropdown = new SelectList(_context.Book, "BookName", "Author");



            //var _custList = from cust in _context.Customer
            //                select cust.FirstMidName;
            //ViewBag.CDropdown = new SelectList(_context.Customer, "CustomerId", "FirstMidName");

            //return View();




        }

       // POST: BorrowList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        //int id, [Bind("BorrowId,BookId,CustomerId")] BorrowList borrowList

        //BorrowList Model
        public async Task<IActionResult> Edit(int id, [Bind("BorrowId,BookId,CustomerId")] BorrowList borrowList)
        {
            //if (ModelState.IsValid)
            //{
            //    var borrowList = new BorrowList();
            //    borrowList.BorrowId = model.BorrowId;
            //    borrowList.BookId = model.BookId;
            //    borrowList.CustomerId = model.CustomerId;
                
            //    _context.Add(borrowList);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View();




            if (id != borrowList.BorrowId)
            {
                return NotFound();
            }

            if (borrowList != null)
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
            ViewData["Fk_BookId"] = new SelectList(_context.Book, "BookId", "BookName", borrowList.Fk_BookId);
            ViewData["Fk_CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FirstMidName", borrowList.Fk_CustomerId);
            return View(borrowList);
        }

        // GET: BorrowList/Delete/5
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

        // POST: BorrowList/Delete/5
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
