using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class addmigrationKiemTra_ThayDoiDuLieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("12d96467-6e0c-4447-bc89-c563b15e74da"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("5b768fea-99bc-480e-8a85-f3eb2e84a2a0"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("bbfeabde-af01-43da-bd12-2f0a9465570e"));

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("8e411a4f-4787-40be-ac66-98976fc5f983"), null, new DateTime(2019, 12, 29, 3, 2, 32, 888, DateTimeKind.Utc).AddTicks(7007), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("78fc09bf-42f1-45b1-b165-afc472ce191a"), null, new DateTime(2019, 12, 29, 3, 2, 32, 889, DateTimeKind.Utc).AddTicks(7362), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("5833dcc0-03c1-4a10-81ac-40d21467c3b5"), null, new DateTime(2019, 12, 29, 3, 2, 32, 889, DateTimeKind.Utc).AddTicks(7477), "LycheeTea", 55000.0, 75, null, null },
                    { new Guid("b89da4d2-5983-462f-baaf-52dc16e361c3"), null, new DateTime(2019, 12, 29, 3, 2, 32, 889, DateTimeKind.Utc).AddTicks(7505), "Test", 55000.0, 75, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("5833dcc0-03c1-4a10-81ac-40d21467c3b5"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("78fc09bf-42f1-45b1-b165-afc472ce191a"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("8e411a4f-4787-40be-ac66-98976fc5f983"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("b89da4d2-5983-462f-baaf-52dc16e361c3"));

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("5b768fea-99bc-480e-8a85-f3eb2e84a2a0"), null, new DateTime(2019, 12, 29, 2, 34, 46, 399, DateTimeKind.Utc).AddTicks(1220), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("12d96467-6e0c-4447-bc89-c563b15e74da"), null, new DateTime(2019, 12, 29, 2, 34, 46, 400, DateTimeKind.Utc).AddTicks(5107), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("bbfeabde-af01-43da-bd12-2f0a9465570e"), null, new DateTime(2019, 12, 29, 2, 34, 46, 400, DateTimeKind.Utc).AddTicks(5265), "LycheeTea", 55000.0, 75, null, null });
        }
    }
}
