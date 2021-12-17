using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkaShop.Data.Migrations
{
    public partial class AddIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 16, 10, 28, 18, 607, DateTimeKind.Local).AddTicks(4794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 16, 9, 55, 44, 815, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("bafd3e3d-dfd1-44ad-a676-d1343f6e12cd"), "4efce6da-eb3b-4922-bcdb-ce4d82c369bc", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirsName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("492bf905-00fa-4b70-bb97-63553b33f9fb"), 0, "ba13ef47-8a39-47b0-ad5e-14192d40fc73", new DateTime(1997, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhatnamtran100217@gmail.com", true, "Nam", "Tran", false, null, "nhatnamtran100217@gmail.com", "admin", "AQAAAAEAACcQAAAAEGgNA5/Q+O9gqwHrHsnhMFdHC0vRJEUC5dcdVxvPA55FXR+Mo7XGgzCxPmF5b9p+UA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 16, 10, 28, 18, 642, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("492bf905-00fa-4b70-bb97-63553b33f9fb"), new Guid("bafd3e3d-dfd1-44ad-a676-d1343f6e12cd") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("492bf905-00fa-4b70-bb97-63553b33f9fb"), new Guid("bafd3e3d-dfd1-44ad-a676-d1343f6e12cd") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bafd3e3d-dfd1-44ad-a676-d1343f6e12cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("492bf905-00fa-4b70-bb97-63553b33f9fb"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 16, 9, 55, 44, 815, DateTimeKind.Local).AddTicks(990),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 12, 16, 10, 28, 18, 607, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 16, 9, 55, 44, 849, DateTimeKind.Local).AddTicks(5770));
        }
    }
}
