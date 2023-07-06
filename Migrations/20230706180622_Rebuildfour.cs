using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HyperDuckLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Rebuildfour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstMidName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "BorrowList",
                columns: table => new
                {
                    BorrowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fk_BookId = table.Column<int>(type: "int", nullable: false),
                    Fk_CustomerId = table.Column<int>(type: "int", nullable: false),
                    BorrowedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsReturned = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowList", x => x.BorrowId);
                    table.ForeignKey(
                        name: "FK_BorrowList_Book_Fk_BookId",
                        column: x => x.Fk_BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowList_Customer_Fk_CustomerId",
                        column: x => x.Fk_CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "BookDescription", "BookName" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "A story of wealth, love, and the American Dream", "The Great Gatsby" },
                    { 2, "Harper Lee", "A powerful exploration of racial injustice in the American South", "To Kill a Mockingbird" },
                    { 3, "Jane Austen", "A classic tale of love, society, and overcoming prejudices", "Pride and Prejudice" },
                    { 4, "George Orwell", "A dystopian novel depicting a totalitarian society", "1984" },
                    { 5, "J.D. Salinger", "A coming-of-age story about a teenager struggling with society and identity", "The Catcher in the Rye" },
                    { 6, "Herman Melville", "A gripping tale of obsession and revenge at sea", "Moby Dick" },
                    { 7, "Virginia Woolf", "A pioneering modernist novel exploring themes of time and perception", "To the Lighthouse" },
                    { 8, "Aldous Huxley", "A dystopian vision of a futuristic society", "Brave New World" },
                    { 9, "Mark Twain", "A classic American novel following the journey of a young boy and a runaway slave", "The Adventures of Huckleberry Finn" },
                    { 10, "J.R.R. Tolkien", "An epic fantasy quest to destroy a powerful ring", "The Lord of the Rings" },
                    { 11, "Charlotte Brontë", "A compelling story of love, independence, and societal expectations", "Jane Eyre" },
                    { 12, "John Steinbeck", "An iconic novel depicting the hardships of the Great Depression", "The Grapes of Wrath" },
                    { 13, "Oscar Wilde", "A philosophical novel exploring the pursuit of pleasure and the consequences of vanity", "The Picture of Dorian Gray" },
                    { 14, "Fyodor Dostoevsky", "A psychological thriller revolving around guilt, morality, and redemption", "Crime and Punishment" },
                    { 15, "Mary Shelley", "A chilling tale of science, creation, and the consequences of playing god", "Frankenstein" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Email", "FirstMidName", "LastName", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 1, "neque@hotmail.couk", "Kimberley", "SurSykes", "0701-66 35 76", "ksursykes@google.couk" },
                    { 2, "in.lorem@icloud.edu", "Kevin", "SurLloyd", "0708-52 88 49", "k.surlloyd@outlook.edu" },
                    { 3, "mattis@yahoo.couk", "Maite", "SurHurley", "0707-77 51 16", "surhurley_maite@icloud.com" },
                    { 4, "ipsum.non@icloud.edu", "Hyatt", "SurKramer", "0702-95 57 34", "s.hyatt8702@hotmail.org" },
                    { 5, "erat.vivamus@yahoo.edu", "Philip", "SurCochran", "0709-86 58 33", "p_surcochran@hotmail.org" },
                    { 6, "lorem@yahoo.org", "Jana", "SurCarver", "0703-71 42 48", "surcarverjana@hotmail.couk" },
                    { 7, "ligula.nullam@yahoo.ca", "Damon", "SurHarrell", "0708-85 23 09", "surharrell.damon1166@aol.com" },
                    { 8, "suspendisse.dui@hotmail.ca", "Rylee", "SurPennington", "0708-00 30 24", "surpenningtonrylee6337@aol.org" },
                    { 9, "curabitur@hotmail.ca", "Kim", "SurRandolph", "0701-03 32 81", "kim_surrandolph6745@yahoo.com" },
                    { 10, "suspendisse@outlook.net", "Noah", "SurHampton", "0700-93 65 59", "n-surhampton@outlook.com" },
                    { 11, "purus.nullam.scelerisque@aol.com", "Zena", "SurOneal", "0701-26 76 92", "suroneal.zena@hotmail.org" },
                    { 12, "odio@icloud.org", "Latifah", "SurPorter", "0708-46 64 11", "latifah-surporter4108@hotmail.com" },
                    { 13, "vulputate.dui@icloud.org", "Lydia", "SurTalley", "0703-44 10 67", "surtalley.lydia5531@yahoo.net" },
                    { 14, "mauris.ut.mi@aol.couk", "Eleanor", "SurSargent", "0702-84 40 79", "eleanor_sursargent3580@yahoo.couk" },
                    { 15, "ultrices.duis.volutpat@outlook.org", "Lacey", "SurOrtiz", "0707-55 63 95", "lacey_surortiz9167@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "BorrowList",
                columns: new[] { "BorrowId", "BorrowedDate", "DueDate", "Fk_BookId", "Fk_CustomerId", "IsReturned" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, true },
                    { 2, new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 14, true },
                    { 3, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 13, false },
                    { 4, new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 12, false },
                    { 5, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 11, false },
                    { 6, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 10, false },
                    { 7, new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 9, false },
                    { 8, new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 8, false },
                    { 9, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 7, true },
                    { 10, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 6, true },
                    { 11, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 5, false },
                    { 12, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 4, false },
                    { 13, new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 3, false },
                    { 14, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2, true },
                    { 15, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowList_Fk_BookId",
                table: "BorrowList",
                column: "Fk_BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowList_Fk_CustomerId",
                table: "BorrowList",
                column: "Fk_CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowList");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
