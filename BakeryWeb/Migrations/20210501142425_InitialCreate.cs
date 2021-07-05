using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakerys",
                columns: table => new
                {
                    BakeryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakeryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BakeryPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BakeryDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BakeryExpire = table.Column<int>(type: "int", nullable: false),
                    BakeryStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakerys", x => x.BakeryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bakerys");
        }
    }
}
