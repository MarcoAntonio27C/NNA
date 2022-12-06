using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class bdNormal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Estatus",
                table: "Denuncia");

            migrationBuilder.AddColumn<Guid>(
                name: "IdFiscalia",
                table: "Denuncia",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdFiscalia",
                table: "Denuncia");

            migrationBuilder.AddColumn<int>(
                name: "Estatus",
                table: "Denuncia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Estatus",
                columns: new[] { "Id", "Nombre", "Status" },
                values: new object[] { 1, "ARCHIVO", true });

            migrationBuilder.InsertData(
                table: "Estatus",
                columns: new[] { "Id", "Nombre", "Status" },
                values: new object[] { 2, "EAT", true });

            migrationBuilder.InsertData(
                table: "Estatus",
                columns: new[] { "Id", "Nombre", "Status" },
                values: new object[] { 3, "CDI", true });
        }
    }
}
