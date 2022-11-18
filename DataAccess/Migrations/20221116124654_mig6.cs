using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_WorkTypes_WorkTypeId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_WorkTypeId",
                table: "Jobs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Jobs_WorkTypeId",
                table: "Jobs",
                column: "WorkTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_WorkTypes_WorkTypeId",
                table: "Jobs",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "WorkTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
