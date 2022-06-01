using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CreateProductOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    NumberOfOrder = table.Column<int>(nullable: false),
                    PurchareOrder = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrders",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
