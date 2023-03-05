using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UdemyBlazorECommerceWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class productSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Spannend", "", 9.99m, "Buch 1" },
                    { 2, "Nineteen Eighty-Four, deutscher Alternativtitel: Neunzehnhundertvierundachtzig), geschrieben von 1946 bis 1948[1] und erschienen im Juni 1949, ist ein dystopischer Roman von George Orwell (eigentlich Eric Arthur Blair), in dem ein totalitärer Überwachungsstaat im Jahr 1984 dargestellt wird. ", "https://upload.wikimedia.org/wikipedia/de/b/b5/1984_%28Frontcover_der_Erstausgabe_von_1949%29.jpg", 19.99m, "1984" },
                    { 3, "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. ", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 10.99m, "The Hitchhiker's Guide to the Galaxy" },
                    { 4, "Als Bibel (altgriechisch βιβλία biblia ‚Bücher‘) oder (Die) Heilige Schrift bezeichnet man die wichtigste religiöse Textsammlung im Judentum wie auch im Christentum.", "https://upload.wikimedia.org/wikipedia/commons/b/b0/Gutenberg_Bible.jpg", 5.99m, "Bibel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
