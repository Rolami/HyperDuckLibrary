using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HyperDuckLibrary.Models;

namespace HyperDuckLibrary.Data
{
    public class HyperDuckLibraryContext : DbContext
    {
        public HyperDuckLibraryContext (DbContextOptions<HyperDuckLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<HyperDuckLibrary.Models.Book> Book { get; set; } = default!;

        public DbSet<HyperDuckLibrary.Models.BorrowList> BorrowList { get; set; } = default!;

        public DbSet<HyperDuckLibrary.Models.Customer> Customer { get; set; } = default!;
    }
}
