using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateDestiny : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageUrls",
                table: "destiny",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 1,
                column: "imageUrls",
                value: "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/1b6270da-85f9-452d-8f11-9e486522397a\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7da3cc7f-75cd-41aa-a2fb-a133e90d1b21\"]");

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 2,
                column: "imageUrls",
                value: "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageUrls",
                table: "destiny");
        }
    }
}
