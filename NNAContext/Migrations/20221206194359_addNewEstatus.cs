using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class addNewEstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "SIN ATENDER");

            migrationBuilder.UpdateData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "ARCHIVO");

            migrationBuilder.UpdateData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "EAT");

            migrationBuilder.InsertData(
                table: "Estatus",
                columns: new[] { "Id", "Nombre", "Status" },
                values: new object[] { 4, "CDI", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "ARCHIVO");

            migrationBuilder.UpdateData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "EAT");

            migrationBuilder.UpdateData(
                table: "Estatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "CDI");
        }
    }
}
