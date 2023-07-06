﻿// <auto-generated />
using System;
using HyperDuckLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HyperDuckLibrary.Migrations
{
    [DbContext(typeof(HyperDuckLibraryContext))]
    partial class HyperDuckLibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HyperDuckLibrary.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "F. Scott Fitzgerald",
                            BookDescription = "A story of wealth, love, and the American Dream",
                            BookName = "The Great Gatsby"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Harper Lee",
                            BookDescription = "A powerful exploration of racial injustice in the American South",
                            BookName = "To Kill a Mockingbird"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Jane Austen",
                            BookDescription = "A classic tale of love, society, and overcoming prejudices",
                            BookName = "Pride and Prejudice"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "George Orwell",
                            BookDescription = "A dystopian novel depicting a totalitarian society",
                            BookName = "1984"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "J.D. Salinger",
                            BookDescription = "A coming-of-age story about a teenager struggling with society and identity",
                            BookName = "The Catcher in the Rye"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "Herman Melville",
                            BookDescription = "A gripping tale of obsession and revenge at sea",
                            BookName = "Moby Dick"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "Virginia Woolf",
                            BookDescription = "A pioneering modernist novel exploring themes of time and perception",
                            BookName = "To the Lighthouse"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Aldous Huxley",
                            BookDescription = "A dystopian vision of a futuristic society",
                            BookName = "Brave New World"
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Mark Twain",
                            BookDescription = "A classic American novel following the journey of a young boy and a runaway slave",
                            BookName = "The Adventures of Huckleberry Finn"
                        },
                        new
                        {
                            BookId = 10,
                            Author = "J.R.R. Tolkien",
                            BookDescription = "An epic fantasy quest to destroy a powerful ring",
                            BookName = "The Lord of the Rings"
                        },
                        new
                        {
                            BookId = 11,
                            Author = "Charlotte Brontë",
                            BookDescription = "A compelling story of love, independence, and societal expectations",
                            BookName = "Jane Eyre"
                        },
                        new
                        {
                            BookId = 12,
                            Author = "John Steinbeck",
                            BookDescription = "An iconic novel depicting the hardships of the Great Depression",
                            BookName = "The Grapes of Wrath"
                        },
                        new
                        {
                            BookId = 13,
                            Author = "Oscar Wilde",
                            BookDescription = "A philosophical novel exploring the pursuit of pleasure and the consequences of vanity",
                            BookName = "The Picture of Dorian Gray"
                        },
                        new
                        {
                            BookId = 14,
                            Author = "Fyodor Dostoevsky",
                            BookDescription = "A psychological thriller revolving around guilt, morality, and redemption",
                            BookName = "Crime and Punishment"
                        },
                        new
                        {
                            BookId = 15,
                            Author = "Mary Shelley",
                            BookDescription = "A chilling tale of science, creation, and the consequences of playing god",
                            BookName = "Frankenstein"
                        });
                });

            modelBuilder.Entity("HyperDuckLibrary.Models.BorrowList", b =>
                {
                    b.Property<int>("BorrowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowId"));

                    b.Property<DateTime?>("BorrowedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fk_BookId")
                        .HasColumnType("int");

                    b.Property<int>("Fk_CustomerId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsReturned")
                        .HasColumnType("bit");

                    b.HasKey("BorrowId");

                    b.HasIndex("Fk_BookId");

                    b.HasIndex("Fk_CustomerId");

                    b.ToTable("BorrowList");

                    b.HasData(
                        new
                        {
                            BorrowId = 1,
                            BorrowedDate = new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 1,
                            Fk_CustomerId = 15,
                            IsReturned = true
                        },
                        new
                        {
                            BorrowId = 2,
                            BorrowedDate = new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 2,
                            Fk_CustomerId = 14,
                            IsReturned = true
                        },
                        new
                        {
                            BorrowId = 3,
                            BorrowedDate = new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 3,
                            Fk_CustomerId = 13,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 4,
                            BorrowedDate = new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 4,
                            Fk_CustomerId = 12,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 5,
                            BorrowedDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 5,
                            Fk_CustomerId = 11,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 6,
                            BorrowedDate = new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 6,
                            Fk_CustomerId = 10,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 7,
                            BorrowedDate = new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 7,
                            Fk_CustomerId = 9,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 8,
                            BorrowedDate = new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 8,
                            Fk_CustomerId = 8,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 9,
                            BorrowedDate = new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 9,
                            Fk_CustomerId = 7,
                            IsReturned = true
                        },
                        new
                        {
                            BorrowId = 10,
                            BorrowedDate = new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 10,
                            Fk_CustomerId = 6,
                            IsReturned = true
                        },
                        new
                        {
                            BorrowId = 11,
                            BorrowedDate = new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 11,
                            Fk_CustomerId = 5,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 12,
                            BorrowedDate = new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 12,
                            Fk_CustomerId = 4,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 13,
                            BorrowedDate = new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 13,
                            Fk_CustomerId = 3,
                            IsReturned = false
                        },
                        new
                        {
                            BorrowId = 14,
                            BorrowedDate = new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 14,
                            Fk_CustomerId = 2,
                            IsReturned = true
                        },
                        new
                        {
                            BorrowId = 15,
                            BorrowedDate = new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fk_BookId = 15,
                            Fk_CustomerId = 1,
                            IsReturned = true
                        });
                });

            modelBuilder.Entity("HyperDuckLibrary.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "neque@hotmail.couk",
                            FirstMidName = "Kimberley",
                            LastName = "SurSykes",
                            PhoneNumber = "0701-66 35 76",
                            UserName = "ksursykes@google.couk"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "in.lorem@icloud.edu",
                            FirstMidName = "Kevin",
                            LastName = "SurLloyd",
                            PhoneNumber = "0708-52 88 49",
                            UserName = "k.surlloyd@outlook.edu"
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "mattis@yahoo.couk",
                            FirstMidName = "Maite",
                            LastName = "SurHurley",
                            PhoneNumber = "0707-77 51 16",
                            UserName = "surhurley_maite@icloud.com"
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "ipsum.non@icloud.edu",
                            FirstMidName = "Hyatt",
                            LastName = "SurKramer",
                            PhoneNumber = "0702-95 57 34",
                            UserName = "s.hyatt8702@hotmail.org"
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "erat.vivamus@yahoo.edu",
                            FirstMidName = "Philip",
                            LastName = "SurCochran",
                            PhoneNumber = "0709-86 58 33",
                            UserName = "p_surcochran@hotmail.org"
                        },
                        new
                        {
                            CustomerId = 6,
                            Email = "lorem@yahoo.org",
                            FirstMidName = "Jana",
                            LastName = "SurCarver",
                            PhoneNumber = "0703-71 42 48",
                            UserName = "surcarverjana@hotmail.couk"
                        },
                        new
                        {
                            CustomerId = 7,
                            Email = "ligula.nullam@yahoo.ca",
                            FirstMidName = "Damon",
                            LastName = "SurHarrell",
                            PhoneNumber = "0708-85 23 09",
                            UserName = "surharrell.damon1166@aol.com"
                        },
                        new
                        {
                            CustomerId = 8,
                            Email = "suspendisse.dui@hotmail.ca",
                            FirstMidName = "Rylee",
                            LastName = "SurPennington",
                            PhoneNumber = "0708-00 30 24",
                            UserName = "surpenningtonrylee6337@aol.org"
                        },
                        new
                        {
                            CustomerId = 9,
                            Email = "curabitur@hotmail.ca",
                            FirstMidName = "Kim",
                            LastName = "SurRandolph",
                            PhoneNumber = "0701-03 32 81",
                            UserName = "kim_surrandolph6745@yahoo.com"
                        },
                        new
                        {
                            CustomerId = 10,
                            Email = "suspendisse@outlook.net",
                            FirstMidName = "Noah",
                            LastName = "SurHampton",
                            PhoneNumber = "0700-93 65 59",
                            UserName = "n-surhampton@outlook.com"
                        },
                        new
                        {
                            CustomerId = 11,
                            Email = "purus.nullam.scelerisque@aol.com",
                            FirstMidName = "Zena",
                            LastName = "SurOneal",
                            PhoneNumber = "0701-26 76 92",
                            UserName = "suroneal.zena@hotmail.org"
                        },
                        new
                        {
                            CustomerId = 12,
                            Email = "odio@icloud.org",
                            FirstMidName = "Latifah",
                            LastName = "SurPorter",
                            PhoneNumber = "0708-46 64 11",
                            UserName = "latifah-surporter4108@hotmail.com"
                        },
                        new
                        {
                            CustomerId = 13,
                            Email = "vulputate.dui@icloud.org",
                            FirstMidName = "Lydia",
                            LastName = "SurTalley",
                            PhoneNumber = "0703-44 10 67",
                            UserName = "surtalley.lydia5531@yahoo.net"
                        },
                        new
                        {
                            CustomerId = 14,
                            Email = "mauris.ut.mi@aol.couk",
                            FirstMidName = "Eleanor",
                            LastName = "SurSargent",
                            PhoneNumber = "0702-84 40 79",
                            UserName = "eleanor_sursargent3580@yahoo.couk"
                        },
                        new
                        {
                            CustomerId = 15,
                            Email = "ultrices.duis.volutpat@outlook.org",
                            FirstMidName = "Lacey",
                            LastName = "SurOrtiz",
                            PhoneNumber = "0707-55 63 95",
                            UserName = "lacey_surortiz9167@hotmail.com"
                        });
                });

            modelBuilder.Entity("HyperDuckLibrary.Models.BorrowList", b =>
                {
                    b.HasOne("HyperDuckLibrary.Models.Book", "Books")
                        .WithMany("BorrowList")
                        .HasForeignKey("Fk_BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HyperDuckLibrary.Models.Customer", "Customers")
                        .WithMany("BorrowList")
                        .HasForeignKey("Fk_CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("HyperDuckLibrary.Models.Book", b =>
                {
                    b.Navigation("BorrowList");
                });

            modelBuilder.Entity("HyperDuckLibrary.Models.Customer", b =>
                {
                    b.Navigation("BorrowList");
                });
#pragma warning restore 612, 618
        }
    }
}
