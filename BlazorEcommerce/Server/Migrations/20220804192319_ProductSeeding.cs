using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Metro 2033 (Russian: Метро 2033) is a 2002 post-apocalyptic fiction novel by Russian author Dmitry Glukhovsky. It is set within the Moscow Metro, where the last survivors hide after a global nuclear holocaust. It has been followed by two sequels, Metro 2034 and Metro 2035, and spawned the Metro media franchise. The book's English edition was published as a tie-in with its video game adaptation in 2010.", "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/Metro_2033_russian_book_front_cover.jpg/220px-Metro_2033_russian_book_front_cover.jpg", 9.99m, "Metro 2033" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "God of War[b] is an action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment (SIE). It was released in April 2018 for the PlayStation 4, with a Microsoft Windows version released in January 2022. The game is the eighth installment in the God of War series, the eighth chronologically, and the sequel to 2010's God of War III.", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/God_of_War_4_cover.jpg/220px-God_of_War_4_cover.jpg", 6.99m, "God of War" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Final Fantasy VII[b] is a 1997 role-playing video game developed by Square for the PlayStation console.", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c2/Final_Fantasy_VII_Box_Art.jpg/220px-Final_Fantasy_VII_Box_Art.jpg", 4.99m, "Final Fantasy VII" });
        }

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
        }
    }
}
