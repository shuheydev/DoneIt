using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoneIt.Migrations
{
    public partial class Add_OwnerId_and_PrivateId_to_WorkingItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "To",
                table: "WorkingItems",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "WorkingItems",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PrivateId",
                table: "WorkingItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "WorkingItems");

            migrationBuilder.DropColumn(
                name: "PrivateId",
                table: "WorkingItems");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "To",
                table: "WorkingItems",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);
        }
    }
}
