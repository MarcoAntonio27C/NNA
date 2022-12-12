using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class addEstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estatus",
                columns: new[] { "Id", "Nombre", "Status" },
                values: new object[,]
                {
                    { 1, "SIN ATENDER", true },
                    { 2, "ARCHIVO", true },
                    { 3, "EAT", true },
                    { 4, "CDI", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
