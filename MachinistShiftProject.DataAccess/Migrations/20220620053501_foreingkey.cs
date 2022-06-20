using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MachinistShiftProject.DataAccess.Migrations
{
    public partial class foreingkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitions_TaskTitleId",
                table: "TaskDefinitions",
                column: "TaskTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDefinitions_TaskTitles_TaskTitleId",
                table: "TaskDefinitions",
                column: "TaskTitleId",
                principalTable: "TaskTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskDefinitions_TaskTitles_TaskTitleId",
                table: "TaskDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_TaskDefinitions_TaskTitleId",
                table: "TaskDefinitions");
        }
    }
}
