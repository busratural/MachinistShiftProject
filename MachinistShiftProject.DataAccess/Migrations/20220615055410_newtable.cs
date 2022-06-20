using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MachinistShiftProject.DataAccess.Migrations
{
    public partial class newtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expedition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpeditionDirection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskNumber = table.Column<int>(type: "int", nullable: false),
                    Desk = table.Column<int>(type: "int", nullable: false),
                    ExpeditionNumber = table.Column<int>(type: "int", nullable: false),
                    DepartureTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Headway = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedition", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expedition");
        }
    }
}
