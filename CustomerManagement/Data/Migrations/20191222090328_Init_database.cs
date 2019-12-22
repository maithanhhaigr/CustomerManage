using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class Init_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("0ebbf7ff-3745-41f4-8581-27b67239bd81"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("48661a04-177b-43c1-aa1e-c0f09905eeba"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("a5b28fac-29ac-4a88-aa87-3480a0a8f632"));

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

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
                values: new object[] { new Guid("48661a04-177b-43c1-aa1e-c0f09905eeba"), null, new DateTime(2019, 11, 24, 7, 9, 20, 446, DateTimeKind.Utc).AddTicks(1326), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("0ebbf7ff-3745-41f4-8581-27b67239bd81"), null, new DateTime(2019, 11, 24, 7, 9, 20, 448, DateTimeKind.Utc).AddTicks(2204), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("a5b28fac-29ac-4a88-aa87-3480a0a8f632"), null, new DateTime(2019, 11, 24, 7, 9, 20, 448, DateTimeKind.Utc).AddTicks(2361), "LycheeTea", 55000.0, 75, null, null });
        }
    }
}
