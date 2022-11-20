using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class AddColumnFullname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 20, 11, 45, 46, 764, DateTimeKind.Utc).AddTicks(9269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 20, 11, 43, 42, 516, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 20, 11, 45, 46, 765, DateTimeKind.Utc).AddTicks(3731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 20, 11, 43, 42, 516, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 20, 11, 43, 42, 516, DateTimeKind.Utc).AddTicks(2805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 20, 11, 45, 46, 764, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 20, 11, 43, 42, 516, DateTimeKind.Utc).AddTicks(7273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 20, 11, 45, 46, 765, DateTimeKind.Utc).AddTicks(3731));
        }
    }
}
