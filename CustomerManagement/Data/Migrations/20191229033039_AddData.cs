using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4bcbedc0-1d86-4f1c-abee-81aada4fb952"), null, new DateTime(2019, 12, 29, 3, 30, 39, 456, DateTimeKind.Utc).AddTicks(9532), "Oto", null, null },
                    { new Guid("d43c87f3-79df-4bbf-88c7-fccc98e53548"), null, new DateTime(2019, 12, 29, 3, 30, 39, 457, DateTimeKind.Utc).AddTicks(9499), "Moto", null, null },
                    { new Guid("a72b1b09-62c5-4f37-847b-f1300d52a0fa"), null, new DateTime(2019, 12, 29, 3, 30, 39, 457, DateTimeKind.Utc).AddTicks(9615), "Xemay", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0a2f7cb5-c494-4bc4-ae54-eb0a152a67f3"), null, new DateTime(2019, 12, 29, 3, 30, 39, 458, DateTimeKind.Utc).AddTicks(117), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("9c31663e-34e5-43a3-b9a9-23695b24cb6c"), null, new DateTime(2019, 12, 29, 3, 30, 39, 458, DateTimeKind.Utc).AddTicks(1402), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("cf7b8ee8-b47c-49cd-8ea1-fd9074558cc6"), null, new DateTime(2019, 12, 29, 3, 30, 39, 458, DateTimeKind.Utc).AddTicks(1447), "LycheeTea", 55000.0, 75, null, null },
                    { new Guid("6c9935ed-3d36-4640-b669-04a637d017da"), null, new DateTime(2019, 12, 29, 3, 30, 39, 458, DateTimeKind.Utc).AddTicks(1464), "Test", 55000.0, 75, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bcbedc0-1d86-4f1c-abee-81aada4fb952"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a72b1b09-62c5-4f37-847b-f1300d52a0fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d43c87f3-79df-4bbf-88c7-fccc98e53548"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("0a2f7cb5-c494-4bc4-ae54-eb0a152a67f3"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("6c9935ed-3d36-4640-b669-04a637d017da"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("9c31663e-34e5-43a3-b9a9-23695b24cb6c"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("cf7b8ee8-b47c-49cd-8ea1-fd9074558cc6"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

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
    }
}
