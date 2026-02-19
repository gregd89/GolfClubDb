using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfClubDb.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Handicap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    TeeDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TeeTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    Player1Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player1Handicap = table.Column<int>(type: "int", nullable: false),
                    Player2Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player2Handicap = table.Column<int>(type: "int", nullable: false),
                    Player3Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player3Handicap = table.Column<int>(type: "int", nullable: false),
                    Player4Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player4Handicap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MemberId",
                table: "Bookings",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
