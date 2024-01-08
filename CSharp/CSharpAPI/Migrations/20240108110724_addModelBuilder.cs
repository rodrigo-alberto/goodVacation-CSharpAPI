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
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "destiny",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "destiny",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "destiny",
                newName: "id");

            migrationBuilder.InsertData(
                table: "destiny",
                columns: new[] { "id", "city", "name" },
                values: new object[,]
                {
                    { 1, "Lençois", "Cachoeira do Mosquito" },
                    { 2, "Iraquara", "Pratinha" }
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

            migrationBuilder.RenameColumn(
                name: "name",
                table: "destiny",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "destiny",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "destiny",
                newName: "Id");
        }
    }
}
