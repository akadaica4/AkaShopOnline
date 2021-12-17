using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkaShop.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 16, 10, 28, 18, 607, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bafd3e3d-dfd1-44ad-a676-d1343f6e12cd"),
                column: "ConcurrencyStamp",
                value: "72d9068d-44e8-43c0-9beb-44db5247af80");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("492bf905-00fa-4b70-bb97-63553b33f9fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f86ef84-7b78-4a40-b16f-dbc493684230", "AQAAAAEAACcQAAAAEH/7Iw+DyCXRDZGhao7jjUl31aJxhN1zVkUIIfo776lMslPNM5mrHI8BGYiMAv08WA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 16, 16, 41, 18, 606, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 16, 10, 28, 18, 607, DateTimeKind.Local).AddTicks(4794),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bafd3e3d-dfd1-44ad-a676-d1343f6e12cd"),
                column: "ConcurrencyStamp",
                value: "4efce6da-eb3b-4922-bcdb-ce4d82c369bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("492bf905-00fa-4b70-bb97-63553b33f9fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba13ef47-8a39-47b0-ad5e-14192d40fc73", "AQAAAAEAACcQAAAAEGgNA5/Q+O9gqwHrHsnhMFdHC0vRJEUC5dcdVxvPA55FXR+Mo7XGgzCxPmF5b9p+UA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 16, 10, 28, 18, 642, DateTimeKind.Local).AddTicks(8455));
        }
    }
}
