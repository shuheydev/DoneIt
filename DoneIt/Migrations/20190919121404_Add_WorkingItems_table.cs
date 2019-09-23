using Microsoft.EntityFrameworkCore.Migrations;

namespace DoneIt.Migrations
{
    public partial class Add_WorkingItems_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkingItem",
                table: "WorkingItem");

            migrationBuilder.RenameTable(
                name: "WorkingItem",
                newName: "WorkingItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkingItems",
                table: "WorkingItems",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkingItems",
                table: "WorkingItems");

            migrationBuilder.RenameTable(
                name: "WorkingItems",
                newName: "WorkingItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkingItem",
                table: "WorkingItem",
                column: "Id");
        }
    }
}
