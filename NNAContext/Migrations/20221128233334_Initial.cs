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
                    Expediente = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    IdCaso = table.Column<int>(type: "int", nullable: false),
                    IdMp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdFiscalia = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                name: "Fiscalias",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acronimo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: false)
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
                    Estatus = table.Column<bool>(type: "bit", nullable: false),
                    IdUnidad = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MP", x => x.Id);
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
                name: "Unidades",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: false),
                    IdFiscalia = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: false),
                    IdRol = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdFiscalia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUnidad = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    { new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"), "ADMINISTRADOR DEL SISTEMA, TIENE ACCESO A TODO", true, "ADMINISTRADOR" },
                    { new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c"), "ENCARGADO DE VER Y ASIGNAR LAS DENUNCIAS RECIBIDAS", true, "FISCALIA ESPECIALIZADA" },
                    { new Guid("aec4592c-fe97-47d0-97d2-1933fd2da4b9"), "PUEDE VER TODAS LAS DENUNCIAS DE SUS AGENTES DEL MINISTERIO PUBLICO", true, "TITULAR DE UNIDAD" },
                    { new Guid("6f1be536-c224-4f31-914e-c9d00cce1eb9"), "AGENTE DEL MINISTERIO PUBLICO", true, "AGENTE DEL MINISTERIO PUBLICO" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "ApellidoMaterno", "ApellidoPaterno", "Contraseña", "Correo", "Estatus", "IdFiscalia", "IdRol", "IdUnidad", "Nombre" },
                values: new object[] { new Guid("1e28ad5c-8897-4f35-846e-beaede16b3b0"), null, null, "123qwe", "root@fiscalia.puebla.gob.mx", true, new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"), new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"), new Guid("1d02eda0-a6b8-4c08-9888-e61db604ecf0"), "Administrador" });

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
                    { 2, "Adolescentes" },
                    { 1, "Niños y Niñas" }
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

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Fiscalias",
                columns: new[] { "Id", "Acronimo", "Estatus", "Nombre" },
                values: new object[,]
                {
                    { new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"), "NONE", true, " NONE" },
                    { new Guid("30df8b24-2f67-49c1-922d-0b1fb219aef9"), "FEIDVGM", true, "Fiscalía Especializada en Investigación de Delitos de Violencia de Género Contra las Mujeres" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Unidades",
                columns: new[] { "Id", "Estatus", "IdFiscalia", "Nombre" },
                values: new object[,]
                {
                    { new Guid("1d02eda0-a6b8-4c08-9888-e61db604ecf0"), true, new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"), " NONE" },
                    { new Guid("e13f9fdb-f883-4a0f-b1d5-66ce02249944"), true, new Guid("30df8b24-2f67-49c1-922d-0b1fb219aef9"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS SEXUALES Y CIBERACOSO" }
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
                name: "Fiscalias",
                schema: "Catalogo");

            migrationBuilder.DropTable(
                name: "MP");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Unidades",
                schema: "Catalogo");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
