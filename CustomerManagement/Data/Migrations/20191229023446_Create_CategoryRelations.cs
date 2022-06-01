using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class Create_CategoryRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

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

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

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
    }
}
