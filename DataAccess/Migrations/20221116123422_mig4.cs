using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkTypes_Jobs_WorkTypeId",
                table: "WorkTypes");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "WorkTypeId",
                table: "WorkTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_WorkTypes_WorkTypeId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_WorkTypeId",
                table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "WorkTypeId",
                table: "WorkTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTypes_Jobs_WorkTypeId",
                table: "WorkTypes",
                column: "WorkTypeId",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
