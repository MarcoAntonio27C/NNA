using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NNAContext.Migrations
{
    public partial class AddFiscalia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fiscalias",
                columns: new[] { "Id", "Acronimo", "Nombre", "Status" },
                values: new object[] { new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"), "NONE", "NONE", true });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("1e28ad5c-8897-4f35-846e-beaede16b3b0"),
                columns: new[] { "IdFiscalia", "Nombre" },
                values: new object[] { new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"), "Administrador" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("542ac5f1-da0f-4454-9700-defa2d131b9d"),
                columns: new[] { "IdFiscalia", "Nombre" },
                values: new object[] { new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"), "Marco Antonio" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fiscalias",
                keyColumn: "Id",
                keyValue: new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("1e28ad5c-8897-4f35-846e-beaede16b3b0"),
                columns: new[] { "IdFiscalia", "Nombre" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("542ac5f1-da0f-4454-9700-defa2d131b9d"),
                columns: new[] { "IdFiscalia", "Nombre" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
