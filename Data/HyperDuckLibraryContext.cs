using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HyperDuckLibrary.Models;
using Elfie.Serialization;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.Text.Json;

namespace HyperDuckLibrary.Data
{
    public class HyperDuckLibraryContext : DbContext
    {
        public HyperDuckLibraryContext(DbContextOptions<HyperDuckLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<HyperDuckLibrary.Models.Book> Book { get; set; } = default!;

        public DbSet<HyperDuckLibrary.Models.Customer> Customer { get; set; } = default!;

        public DbSet<HyperDuckLibrary.Models.BorrowList> BorrowList { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Load data from Customer.json
            var customerJson = File.ReadAllText(("Data/Customer.json"));
            var customers = JsonSerializer.Deserialize<List<Customer>>(customerJson);
            modelBuilder.Entity<Customer>().HasData(customers);

            // Load data from Books.json
            var booksJson = File.ReadAllText(("Data/Books.json"));
            var books = JsonSerializer.Deserialize<List<Book>>(booksJson);
            modelBuilder.Entity<Book>().HasData(books);

            // Load data from Borrowed.json
            var borrowedJson = File.ReadAllText(("Data/Borrowed.json"));
            var borrowedList = JsonSerializer.Deserialize<List<BorrowList>>(borrowedJson);

            // Adjust the DueDate for each borrow entry
            foreach (var borrow in borrowedList)
            {
                if (borrow.BorrowedDate.HasValue)
                {
                    borrow.DueDate = borrow.BorrowedDate.Value.AddDays(28);
                }
            }

            modelBuilder.Entity<BorrowList>().HasData(borrowedList);

            base.OnModelCreating(modelBuilder);
        }

    }
}
