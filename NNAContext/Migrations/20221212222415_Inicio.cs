using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class Inicio : Migration
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
                name: "Estatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estatus", x => x.Id);
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
                name: "Municipio",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
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
                    { 1, "Niños y Niñas" },
                    { 2, "Adolescentes" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Emotion",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 5, "PREOCUPADO" },
                    { 3, "ENOJADO" },
                    { 4, "TRISTE" },
                    { 1, "BIEN" },
                    { 2, "MAL" }
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
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 149, "Santiago Miahuatlán" },
                    { 140, "San Pedro Cholula" },
                    { 141, "San Pedro Yeloixtlahuaca" },
                    { 142, "San Salvador el Seco" },
                    { 143, "San Salvador el Verde" },
                    { 144, "San Salvador Huixcolotla" },
                    { 145, "San Sebastián Tlacotepec" },
                    { 146, "Santa Catarina Tlaltempan" },
                    { 147, "Santa Inés Ahuatempan" },
                    { 148, "Santa Isabel Cholula" },
                    { 150, "Huehuetlán el Grande" },
                    { 159, "Teopantlán" },
                    { 152, "Soltepec" },
                    { 153, "Tecali de Herrera" },
                    { 154, "Tecamachalco" },
                    { 155, "Tecomatlán" },
                    { 156, "Tehuacán" },
                    { 157, "Tehuitzingo" },
                    { 158, "Tenampulco" },
                    { 139, "San Pablo Anicano" },
                    { 160, "Teotlalco" },
                    { 161, "Tepanco de López" },
                    { 162, "Tepango de Rodríguez" },
                    { 151, "Santo Tomás Hueyotlipan" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 138, "San Nicolás de los Ranchos" },
                    { 129, "San José Miahuatlán" },
                    { 136, "San Miguel Xoxtla" },
                    { 112, "Petlalcingo" },
                    { 113, "Piaxtla" },
                    { 114, "Puebla" },
                    { 115, "Quecholac" },
                    { 116, "Quimixtlán" },
                    { 117, "Rafael Lara Grajales" },
                    { 118, "Los Reyes de Juárez" },
                    { 119, "San Andrés Cholula" },
                    { 120, "San Antonio Cañada" },
                    { 121, "San Diego la Mesa Tochimiltzingo" },
                    { 122, "San Felipe Teotlalcingo" },
                    { 137, "San Nicolás Buenos Aires" },
                    { 123, "San Felipe Tepatlán" },
                    { 125, "San Gregorio Atzompa" },
                    { 126, "San Jerónimo Tecuanipan" },
                    { 127, "San Jerónimo Xayacatlán" },
                    { 128, "San José Chiapa" },
                    { 163, "Tepatlaxco de Hidalgo" },
                    { 130, "San Juan Atenco" },
                    { 131, "San Juan Atzompa" },
                    { 132, "San Martín Texmelucan" },
                    { 133, "San Martín Totoltepec" },
                    { 134, "San Matías Tlalancaleca" },
                    { 135, "San Miguel Ixitlán" },
                    { 124, "San Gabriel Chilac" },
                    { 164, "Tepeaca" },
                    { 173, "Teteles de Ávila Castillo" },
                    { 166, "Tepeojuma" },
                    { 195, "Vicente Guerrero" },
                    { 196, "Xayacatlán de Bravo" },
                    { 197, "Xicotepec" },
                    { 198, "Xicotlán" },
                    { 199, "Xiutetelco" },
                    { 200, "Xochiapulco" },
                    { 201, "Xochiltepec" },
                    { 202, "Xochitlán de Vicente Suárez" },
                    { 203, "Xochitlán Todos Santos" },
                    { 204, "Yaonáhuac" },
                    { 205, "Yehualtepec" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 206, "Zacapala" },
                    { 207, "Zacapoaxtla" },
                    { 208, "Zacatlán" },
                    { 209, "Zapotitlán" },
                    { 210, "Zapotitlán de Méndez" },
                    { 211, "Zaragoza" },
                    { 212, "Zautla" },
                    { 213, "Zihuateutla" },
                    { 214, "Zinacatepec" },
                    { 215, "Zongozotla" },
                    { 216, "Zoquiapan" },
                    { 217, "Zoquitlán" },
                    { 194, "Venustiano Carranza" },
                    { 193, "Tzicatlacoyan" },
                    { 192, "Tuzamapan de Galeana" },
                    { 191, "Tulcingo" },
                    { 167, "Tepetzintla" },
                    { 168, "Tepexco" },
                    { 169, "Tepexi de Rodríguez" },
                    { 170, "Tepeyahualco" },
                    { 171, "Tepeyahualco de Cuauhtémoc" },
                    { 172, "Tetela de Ocampo" },
                    { 111, "Pantepec" },
                    { 174, "Teziutlán" },
                    { 175, "Tianguismanalco" },
                    { 176, "Tilapa" },
                    { 177, "Tlacotepec de Benito Juárez" },
                    { 165, "Tepemaxalco" },
                    { 178, "Tlacuilotepec" },
                    { 180, "Tlahuapan" },
                    { 181, "Tlaltenango" },
                    { 182, "Tlanepantla" },
                    { 183, "Tlaola" },
                    { 184, "Tlapacoya" },
                    { 185, "Tlapanalá" },
                    { 186, "Tlatlauquitepec" },
                    { 187, "Tlaxco" },
                    { 188, "Tochimilco" },
                    { 189, "Tochtepec" },
                    { 190, "Totoltepec de Guerrero" },
                    { 179, "Tlachichuca" },
                    { 110, "Palmar de Bravo" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 101, "Nauzontla" },
                    { 108, "Oriental" },
                    { 29, "Caxhuacan" },
                    { 30, "Coatepec" },
                    { 31, "Coatzingo" },
                    { 32, "Cohetzala" },
                    { 33, "Cohuecan" },
                    { 34, "Coronango" },
                    { 35, "Coxcatlán" },
                    { 36, "Coyomeapan" },
                    { 37, "Coyotepec" },
                    { 38, "Cuapiaxtla de Madero" },
                    { 39, "Cuautempan" },
                    { 40, "Cuautinchán" },
                    { 41, "Cuautlancingo" },
                    { 42, "Cuayuca de Andrade" },
                    { 43, "Cuetzalan del Progreso" },
                    { 44, "Cuyoaco" },
                    { 45, "Chalchicomula de Sesma" },
                    { 46, "Chapulco" },
                    { 47, "Chiautla" },
                    { 48, "Chiautzingo" },
                    { 49, "Chiconcuautla" },
                    { 50, "Chichiquila" },
                    { 51, "Chietla" },
                    { 28, "Camocuautla" },
                    { 27, "Caltepec" },
                    { 26, "Calpan" },
                    { 25, "Ayotoxco de Guerrero" },
                    { 1, "Acajete" },
                    { 2, "Acateno" },
                    { 3, "Acatlán" },
                    { 4, "Acatzingo" },
                    { 5, "Acteopan" },
                    { 6, "Ahuacatlán" },
                    { 7, "Ahuatlán" },
                    { 8, "Ahuazotepec" },
                    { 9, "Ahuehuetitla" },
                    { 10, "Ajalpan" },
                    { 11, "Albino Zertuche" },
                    { 52, "Chigmecatitlán" },
                    { 12, "Aljojuca" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 14, "Amixtlán" },
                    { 15, "Amozoc" },
                    { 16, "Aquixtla" },
                    { 17, "Atempan" },
                    { 18, "Atexcal" },
                    { 19, "Atlixco" },
                    { 20, "Atoyatempan" },
                    { 21, "Atzala" },
                    { 22, "Atzitzihuacán" },
                    { 23, "Atzitzintla" },
                    { 24, "Axutla" },
                    { 13, "Altepexi" },
                    { 53, "Chignahuapan" },
                    { 54, "Chignautla" },
                    { 55, "Chila" },
                    { 84, "Ixtepec" },
                    { 85, "Izúcar de Matamoros" },
                    { 86, "Jalpan" },
                    { 87, "Jolalpan" },
                    { 88, "Jonotla" },
                    { 89, "Jopala" },
                    { 90, "Juan C. Bonilla" },
                    { 91, "Juan Galindo" },
                    { 92, "Juan N. Méndez" },
                    { 93, "Lafragua" },
                    { 94, "Libres" },
                    { 95, "La Magdalena Tlatlauquitepec" },
                    { 96, "Mazapiltepec de Juárez" },
                    { 97, "Mixtla" },
                    { 98, "Molcaxac" },
                    { 99, "Cañada Morelos" },
                    { 100, "Naupan" },
                    { 102, "Nealtican" },
                    { 103, "Nicolás Bravo" },
                    { 104, "Nopalucan" },
                    { 105, "Ocotepec" },
                    { 106, "Ocoyucan" },
                    { 107, "Olintla" },
                    { 83, "Ixtacamaxtitlán" },
                    { 109, "Pahuatlán" },
                    { 82, "Ixcaquixtla" },
                    { 80, "Atlequizayan" }
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 56, "Chila de la Sal" },
                    { 57, "Honey" },
                    { 58, "Chilchotla" },
                    { 59, "Chinantla" },
                    { 60, "Domingo Arenas" },
                    { 61, "Eloxochitlán" },
                    { 62, "Epatlán" },
                    { 63, "Esperanza" },
                    { 64, "Francisco Z. Mena" },
                    { 65, "General Felipe Ángeles" },
                    { 66, "Guadalupe" },
                    { 81, "Ixcamilpa de Guerrero" },
                    { 67, "Guadalupe Victoria" },
                    { 69, "Huaquechula" },
                    { 70, "Huatlatlauca" },
                    { 71, "Huauchinango" },
                    { 72, "Huehuetla" },
                    { 73, "Huehuetlán el Chico" },
                    { 74, "Huejotzingo" },
                    { 75, "Hueyapan" },
                    { 76, "Hueytamalco" },
                    { 77, "Hueytlalpan" },
                    { 78, "Huitzilan de Serdán" },
                    { 79, "Huitziltepec" },
                    { 68, "Hermenegildo Galeana" }
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
                name: "Estatus");

            migrationBuilder.DropTable(
                name: "Fiscalias",
                schema: "Catalogo");

            migrationBuilder.DropTable(
                name: "MP");

            migrationBuilder.DropTable(
                name: "Municipio",
                schema: "Catalogo");

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
