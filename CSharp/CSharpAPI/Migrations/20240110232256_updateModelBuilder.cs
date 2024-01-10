using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateModelBuilder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 1,
                column: "imageUrls",
                value: "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/e21efdfa-1b3e-4ad7-ac47-561e304f33c4\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/18274ddb-11b5-4c65-a006-dee24aa1e78f\"]");

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 2,
                column: "imageUrls",
                value: "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/0fe9f6d6-a3ab-4691-bda6-94bddfd922f7\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/5a2b541d-4d6c-4fff-9725-9f85f22cadfe\"]");

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 3,
                column: "imageUrls",
                value: "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d89a7598-da08-4fe4-802c-d45b60f9f8be\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/70027f1a-ca8f-410f-bbfd-3840caa805a8\"]");

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 4,
                column: "imageUrls",
                value: "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/3bdddeb1-7f26-4897-b62c-aafbe38f136c\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/c50c9cc7-d752-4705-981f-33f27359a9bc\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 3,
                column: "imageUrls",
                value: "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\"]");

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 4,
                column: "imageUrls",
                value: "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\"]");
        }
    }
}
