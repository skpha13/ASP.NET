using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4_23.Migrations
{
    /// <inheritdoc />
    public partial class relationFixUserOng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ONGS_Id",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_ONGS_Users_Id",
                table: "ONGS",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ONGS_Users_Id",
                table: "ONGS");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ONGS_Id",
                table: "Users",
                column: "Id",
                principalTable: "ONGS",
                principalColumn: "Id");
        }
    }
}
