using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfClubDb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerMembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Member_MemberId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_MemberId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Player1Name",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Player2Name",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Player3Name",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Player4Name",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "Player4Handicap",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Player3Handicap",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Player2Handicap",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Player1Handicap",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Player1MemberId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player2MemberId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player3MemberId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player4MemberId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Player1MemberId",
                table: "Bookings",
                column: "Player1MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Player2MemberId",
                table: "Bookings",
                column: "Player2MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Player3MemberId",
                table: "Bookings",
                column: "Player3MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Player4MemberId",
                table: "Bookings",
                column: "Player4MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Member_Player1MemberId",
                table: "Bookings",
                column: "Player1MemberId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Member_Player2MemberId",
                table: "Bookings",
                column: "Player2MemberId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Member_Player3MemberId",
                table: "Bookings",
                column: "Player3MemberId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Member_Player4MemberId",
                table: "Bookings",
                column: "Player4MemberId",
                principalTable: "Member",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Member_Player1MemberId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Member_Player2MemberId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Member_Player3MemberId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Member_Player4MemberId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Player1MemberId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Player2MemberId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Player3MemberId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Player4MemberId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Player1MemberId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Player2MemberId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Player3MemberId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Player4MemberId",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "Player4Handicap",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Player3Handicap",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Player2Handicap",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Player1Handicap",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Player1Name",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Player2Name",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Player3Name",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Player4Name",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MemberId",
                table: "Bookings",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Member_MemberId",
                table: "Bookings",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
