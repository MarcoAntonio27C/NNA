using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroDenuncia",
                table: "Denuncia",
                newName: "Expediente");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoMaterno",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApellidoPaterno",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdFiscalia",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdFiscalia",
                table: "Denuncia",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdMp",
                table: "Denuncia",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Fiscalias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acronimo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fiscalias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltaSistema = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdFiscalia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MP", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c"),
                column: "Nombre",
                value: "AGENTE INVESTIGADOR");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Descripcion", "Estatus", "Nombre" },
                values: new object[] { new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"), "ADMINISTRADOR DEL SISTEMA, TIENE ACCESO A TODO", true, "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "ApellidoMaterno", "ApellidoPaterno", "Contraseña", "Correo", "Estatus", "IdFiscalia", "IdRol", "Nombre" },
                values: new object[] { new Guid("1e28ad5c-8897-4f35-846e-beaede16b3b0"), null, null, "123qwe", "admin@fiscalia.puebla.gob.mx", true, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fiscalias");

            migrationBuilder.DropTable(
                name: "MP");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("1e28ad5c-8897-4f35-846e-beaede16b3b0"));

            migrationBuilder.DropColumn(
                name: "ApellidoMaterno",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ApellidoPaterno",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdFiscalia",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdFiscalia",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "IdMp",
                table: "Denuncia");

            migrationBuilder.RenameColumn(
                name: "Expediente",
                table: "Denuncia",
                newName: "NumeroDenuncia");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c"),
                column: "Nombre",
                value: "ASESOR");
        }
    }
}
