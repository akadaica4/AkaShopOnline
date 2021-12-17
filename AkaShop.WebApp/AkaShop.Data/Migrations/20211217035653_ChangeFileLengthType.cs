using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkaShop.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bafd3e3d-dfd1-44ad-a676-d1343f6e12cd"),
                column: "ConcurrencyStamp",
                value: "6650743c-b496-44f7-9cbe-a73427063d45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("492bf905-00fa-4b70-bb97-63553b33f9fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23ddc1eb-268d-4d80-bd89-7bfb40ac60fe", "AQAAAAEAACcQAAAAEKYz+4MMZAJIxwaRhQQzn+SOW9i8nCMlOyzeCuxSCr3c4rRQjP2HHkqO0iDZqciMyQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 17, 10, 56, 52, 182, DateTimeKind.Local).AddTicks(3407));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

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
        }
    }
}
