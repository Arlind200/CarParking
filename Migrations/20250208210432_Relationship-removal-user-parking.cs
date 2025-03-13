using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParking.Migrations
{
    /// <inheritdoc />
    public partial class Relationshipremovaluserparking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parking_User_UserID",
                table: "Parking");

            migrationBuilder.DropIndex(
                name: "IX_Parking_UserID",
                table: "Parking");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Parking");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Parking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Parking_UserID",
                table: "Parking",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Parking_User_UserID",
                table: "Parking",
                column: "UserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
