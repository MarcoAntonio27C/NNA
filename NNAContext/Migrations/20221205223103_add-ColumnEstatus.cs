using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class addColumnEstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
