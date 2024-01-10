using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharpAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateDestiny : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "destiny",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "destiny",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "description", "state" },
                values: new object[] { "Com uma bela queda d’água em meio a grandiosos paredões rochosos, a Cachoeira do Mosquito impressiona pela sua beleza e graciosidade natural.", "Bahia" });

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "city", "description", "name", "state" },
                values: new object[] { "Angra dos Reis", "Um sítio histórico e natural com mais de 100 praias, além de cachoeiras, rios, trilhas, construções históricas e uma rica flora e fauna.", "Ilha Grande", "Rio de Janeiro" });

            migrationBuilder.InsertData(
                table: "destiny",
                columns: new[] { "id", "city", "description", "imageUrls", "name", "state" },
                values: new object[,]
                {
                    { 3, "Aracaju", "Aracaju é um destino que reúne um extenso litoral, praias de rio, centro histórico repleto de museus e mercados públicos, além de uma culinária deliciosa.", "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\"]", "Praia de Atalaia", "Sergipe" },
                    { 4, "Iraquara", "As águas cristalinas do rio Pratinha são um convite para uma pedalada em família, um teste de equilíbrio ou remo em meio à natureza.", "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\"]", "Pratinha", "Bahia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "description",
                table: "destiny");

            migrationBuilder.DropColumn(
                name: "state",
                table: "destiny");

            migrationBuilder.UpdateData(
                table: "destiny",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "city", "name" },
                values: new object[] { "Iraquara", "Pratinha" });
        }
    }
}
