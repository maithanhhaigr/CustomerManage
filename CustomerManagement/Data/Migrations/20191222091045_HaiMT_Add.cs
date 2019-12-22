using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class HaiMT_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("ac1d0d13-7b6e-406c-af13-5030d6fc7e72"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("c85eaea9-2df0-4a68-bb31-5ec791db22d4"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("caa47031-355b-4ef8-9932-0daf58d17e97"));

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("9fb9201d-75ef-4e86-a316-df3f83d2145c"), null, new DateTime(2019, 12, 22, 9, 10, 44, 917, DateTimeKind.Utc).AddTicks(8617), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("3bb41d48-b991-4779-ab57-4204dd3563ba"), null, new DateTime(2019, 12, 22, 9, 10, 44, 918, DateTimeKind.Utc).AddTicks(8910), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("7ce38e30-43cf-4dcd-ab46-1a652611c207"), null, new DateTime(2019, 12, 22, 9, 10, 44, 918, DateTimeKind.Utc).AddTicks(9039), "LycheeTea", 55000.0, 75, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("3bb41d48-b991-4779-ab57-4204dd3563ba"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("7ce38e30-43cf-4dcd-ab46-1a652611c207"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("9fb9201d-75ef-4e86-a316-df3f83d2145c"));

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("c85eaea9-2df0-4a68-bb31-5ec791db22d4"), null, new DateTime(2019, 12, 22, 9, 3, 28, 289, DateTimeKind.Utc).AddTicks(9857), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("caa47031-355b-4ef8-9932-0daf58d17e97"), null, new DateTime(2019, 12, 22, 9, 3, 28, 291, DateTimeKind.Utc).AddTicks(158), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("ac1d0d13-7b6e-406c-af13-5030d6fc7e72"), null, new DateTime(2019, 12, 22, 9, 3, 28, 291, DateTimeKind.Utc).AddTicks(274), "LycheeTea", 55000.0, 75, null, null });
        }
    }
}
