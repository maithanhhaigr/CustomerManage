using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class ChangeColumne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bd466ae-725b-423e-ae25-548481c0b035"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ccd3f8ba-2801-424c-8dac-f4b54df9cb99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fea6cd6e-67d1-4c46-9281-ad17ce107d2d"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("7018fcc7-834d-409d-8b62-1ce73e07a6a2"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("a7b0e01e-f60e-4982-942b-e1831bb60c43"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("a7febab4-46bf-489d-9b5c-a0c1957300c5"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("b0b995b8-2d6a-4345-bc42-48e0efe81121"));

            migrationBuilder.DropColumn(
                name: "PurchareOrder",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("66100038-8eb2-48ab-b25c-7e27fac8d197"), null, new DateTime(2019, 12, 29, 8, 30, 8, 884, DateTimeKind.Utc).AddTicks(1573), "Oto", null, null },
                    { new Guid("2e24acdf-bf79-4a68-9287-30d8ad221dee"), null, new DateTime(2019, 12, 29, 8, 30, 8, 885, DateTimeKind.Utc).AddTicks(1437), "Moto", null, null },
                    { new Guid("840caa3a-0cd0-4f5d-8224-39780b2e000b"), null, new DateTime(2019, 12, 29, 8, 30, 8, 885, DateTimeKind.Utc).AddTicks(1546), "Xemay", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("02475aef-8883-4c9b-b1a8-ada4078e7548"), null, new DateTime(2019, 12, 29, 8, 30, 8, 885, DateTimeKind.Utc).AddTicks(8420), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("b23ed790-b0d7-4d6d-bac3-5673428ce942"), null, new DateTime(2019, 12, 29, 8, 30, 8, 885, DateTimeKind.Utc).AddTicks(9740), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("6fafdf30-988f-4dd0-81ff-2bf5a822b648"), null, new DateTime(2019, 12, 29, 8, 30, 8, 885, DateTimeKind.Utc).AddTicks(9791), "LycheeTea", 55000.0, 75, null, null },
                    { new Guid("b8548967-877e-40e5-b980-e0b3f570646e"), null, new DateTime(2019, 12, 29, 8, 30, 8, 885, DateTimeKind.Utc).AddTicks(9807), "Test", 55000.0, 75, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e24acdf-bf79-4a68-9287-30d8ad221dee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66100038-8eb2-48ab-b25c-7e27fac8d197"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("840caa3a-0cd0-4f5d-8224-39780b2e000b"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("02475aef-8883-4c9b-b1a8-ada4078e7548"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("6fafdf30-988f-4dd0-81ff-2bf5a822b648"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("b23ed790-b0d7-4d6d-bac3-5673428ce942"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("b8548967-877e-40e5-b980-e0b3f570646e"));

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchareOrder",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7bd466ae-725b-423e-ae25-548481c0b035"), null, new DateTime(2019, 12, 29, 7, 17, 9, 134, DateTimeKind.Utc).AddTicks(5482), "Oto", null, null },
                    { new Guid("fea6cd6e-67d1-4c46-9281-ad17ce107d2d"), null, new DateTime(2019, 12, 29, 7, 17, 9, 135, DateTimeKind.Utc).AddTicks(5529), "Moto", null, null },
                    { new Guid("ccd3f8ba-2801-424c-8dac-f4b54df9cb99"), null, new DateTime(2019, 12, 29, 7, 17, 9, 135, DateTimeKind.Utc).AddTicks(5640), "Xemay", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("b0b995b8-2d6a-4345-bc42-48e0efe81121"), null, new DateTime(2019, 12, 29, 7, 17, 9, 136, DateTimeKind.Utc).AddTicks(2876), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("a7b0e01e-f60e-4982-942b-e1831bb60c43"), null, new DateTime(2019, 12, 29, 7, 17, 9, 136, DateTimeKind.Utc).AddTicks(4203), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("a7febab4-46bf-489d-9b5c-a0c1957300c5"), null, new DateTime(2019, 12, 29, 7, 17, 9, 136, DateTimeKind.Utc).AddTicks(4253), "LycheeTea", 55000.0, 75, null, null },
                    { new Guid("7018fcc7-834d-409d-8b62-1ce73e07a6a2"), null, new DateTime(2019, 12, 29, 7, 17, 9, 136, DateTimeKind.Utc).AddTicks(4270), "Test", 55000.0, 75, null, null }
                });
        }
    }
}
