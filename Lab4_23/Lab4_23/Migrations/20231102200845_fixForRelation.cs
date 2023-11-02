using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4_23.Migrations
{
    /// <inheritdoc />
    public partial class fixForRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ONGS_Id",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ONGS_Id",
                table: "Users",
                column: "Id",
                principalTable: "ONGS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ONGS_Id",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ONGS_Id",
                table: "Users",
                column: "Id",
                principalTable: "ONGS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
