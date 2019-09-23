using Microsoft.EntityFrameworkCore.Migrations;

namespace DoneIt.Migrations
{
    public partial class Add_Unique_Constraint_to_PrivateId_in_WorkingItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_WorkingItems_PrivateId",
                table: "WorkingItems",
                column: "PrivateId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkingItems_PrivateId",
                table: "WorkingItems");
        }
    }
}
