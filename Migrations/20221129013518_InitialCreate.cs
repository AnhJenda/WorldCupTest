using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldCup.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flag1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flag2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    score1 = table.Column<int>(type: "int", nullable: false),
                    score2 = table.Column<int>(type: "int", nullable: false),
                    position1 = table.Column<double>(type: "float", nullable: false),
                    position2 = table.Column<double>(type: "float", nullable: false),
                    passing1 = table.Column<int>(type: "int", nullable: false),
                    passing2 = table.Column<int>(type: "int", nullable: false),
                    shootOnTarget1 = table.Column<int>(type: "int", nullable: false),
                    shootOnTarget2 = table.Column<int>(type: "int", nullable: false),
                    yellowCard1 = table.Column<int>(type: "int", nullable: false),
                    yellowCard2 = table.Column<int>(type: "int", nullable: false),
                    redCard1 = table.Column<int>(type: "int", nullable: false),
                    redCard2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Match");
        }
    }
}
