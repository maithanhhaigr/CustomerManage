using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ed750da-df0a-400d-a550-c3d50920ecd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5df9c66-e34f-4d89-952b-5acaaea175fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4804dfe-9e81-4094-a8b0-f17ef7f121db"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("4d5ec273-bf59-49b2-84c3-52824808357d"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("7d362dde-8a7e-4865-b303-65b542f1da1d"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("8d0dde19-3c60-49e4-bccc-7fb3d22c6824"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("de98b990-9f6f-4724-943a-0c47faf4486f"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c5df9c66-e34f-4d89-952b-5acaaea175fc"), null, new DateTime(2019, 12, 29, 7, 4, 36, 860, DateTimeKind.Utc).AddTicks(610), "Oto", null, null },
                    { new Guid("5ed750da-df0a-400d-a550-c3d50920ecd9"), null, new DateTime(2019, 12, 29, 7, 4, 36, 861, DateTimeKind.Utc).AddTicks(132), "Moto", null, null },
                    { new Guid("e4804dfe-9e81-4094-a8b0-f17ef7f121db"), null, new DateTime(2019, 12, 29, 7, 4, 36, 861, DateTimeKind.Utc).AddTicks(236), "Xemay", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7d362dde-8a7e-4865-b303-65b542f1da1d"), null, new DateTime(2019, 12, 29, 7, 4, 36, 861, DateTimeKind.Utc).AddTicks(6628), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("8d0dde19-3c60-49e4-bccc-7fb3d22c6824"), null, new DateTime(2019, 12, 29, 7, 4, 36, 861, DateTimeKind.Utc).AddTicks(7977), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("4d5ec273-bf59-49b2-84c3-52824808357d"), null, new DateTime(2019, 12, 29, 7, 4, 36, 861, DateTimeKind.Utc).AddTicks(8024), "LycheeTea", 55000.0, 75, null, null },
                    { new Guid("de98b990-9f6f-4724-943a-0c47faf4486f"), null, new DateTime(2019, 12, 29, 7, 4, 36, 861, DateTimeKind.Utc).AddTicks(8042), "Test", 55000.0, 75, null, null }
                });
        }
    }
}
