using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharpAPI.Migrations
{
    /// <inheritdoc />
    public partial class addModelBuilder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "destiny",
                columns: new[] { "id", "city", "imageUrls", "name" },
                values: new object[,]
                {
                    { 1, "Lençois", "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/1b6270da-85f9-452d-8f11-9e486522397a\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7da3cc7f-75cd-41aa-a2fb-a133e90d1b21\"]", "Cachoeira do Mosquito" },
                    { 2, "Iraquara", "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\"]", "Pratinha" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
