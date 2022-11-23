using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalogo");

            migrationBuilder.CreateTable(
                name: "Actions",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caso",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Denuncia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroDenuncia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Folio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdadRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ParentsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentsRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Casa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Escuela = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SomeDataRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Evento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventoRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asignada = table.Column<bool>(type: "bit", nullable: false),
                    IdEmotion = table.Column<int>(type: "int", nullable: false),
                    IdAction = table.Column<int>(type: "int", nullable: false),
                    IdCaso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emotion",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emotion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRol = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Estatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Descripcion", "Estatus", "Nombre" },
                values: new object[,]
                {
                    { new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c"), "ENCARGADO DE ASIGNAR LAS DENUNCIAS RECIBIDAS", true, "ASESOR" },
                    { new Guid("6f1be536-c224-4f31-914e-c9d00cce1eb9"), "AGENTE DEL MINISTERIO PUBLICO", true, "MP" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Contraseña", "Correo", "Estatus", "IdRol" },
                values: new object[] { new Guid("542ac5f1-da0f-4454-9700-defa2d131b9d"), "123qwe", "marco_antonio.cantero@fiscalia.puebla.gob.mx", true, new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c") });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Actions",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Alguien me pegó y me lastimó" },
                    { 2, "Alguien me tocó o me hizo tocar su cuerpo" },
                    { 3, "Alguien me grita o me dice cosas malas" },
                    { 4, "Alguien me manda a trabajar" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Caso",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Niños y Niñas" },
                    { 2, "Adolescentes" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Emotion",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "BIEN" },
                    { 2, "MAL" },
                    { 3, "ENOJADO" },
                    { 4, "TRISTE" },
                    { 5, "PREOCUPADO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actions",
                schema: "Catalogo");

            migrationBuilder.DropTable(
                name: "Caso",
                schema: "Catalogo");

            migrationBuilder.DropTable(
                name: "Denuncia");

            migrationBuilder.DropTable(
                name: "Emotion",
                schema: "Catalogo");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
