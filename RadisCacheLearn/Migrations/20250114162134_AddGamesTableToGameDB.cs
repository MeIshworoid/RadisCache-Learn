using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadisCacheLearn.Migrations
{
    /// <inheritdoc />
    public partial class AddGamesTableToGameDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleasedYear = table.Column<DateOnly>(type: "date", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GamePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
