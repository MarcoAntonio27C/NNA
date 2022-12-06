using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class addEstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estatus");
        }
    }
}
