using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4_23.Migrations
{
    /// <inheritdoc />
    public partial class TestRider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ONGHasPostsRelation_ONGS_PostId",
                table: "ONGHasPostsRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ONGHasPostsRelation_Posts_ONGId",
                table: "ONGHasPostsRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ONGS_Users_Id",
                table: "ONGS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ONGS",
                table: "ONGS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ONGHasPostsRelation",
                table: "ONGHasPostsRelation");

            migrationBuilder.RenameTable(
                name: "ONGS",
                newName: "Ongs");

            migrationBuilder.RenameTable(
                name: "ONGHasPostsRelation",
                newName: "OngHasPostsRelation");

            migrationBuilder.RenameColumn(
                name: "ONGId",
                table: "Users",
                newName: "OngId");

            migrationBuilder.RenameColumn(
                name: "numberStars",
                table: "Review",
                newName: "NumberStars");

            migrationBuilder.RenameColumn(
                name: "ONGId",
                table: "OngHasPostsRelation",
                newName: "OngId");

            migrationBuilder.RenameIndex(
                name: "IX_ONGHasPostsRelation_PostId",
                table: "OngHasPostsRelation",
                newName: "IX_OngHasPostsRelation_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ongs",
                table: "Ongs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OngHasPostsRelation",
                table: "OngHasPostsRelation",
                columns: new[] { "OngId", "PostId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OngHasPostsRelation_Ongs_PostId",
                table: "OngHasPostsRelation",
                column: "PostId",
                principalTable: "Ongs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OngHasPostsRelation_Posts_OngId",
                table: "OngHasPostsRelation",
                column: "OngId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ongs_Users_Id",
                table: "Ongs",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OngHasPostsRelation_Ongs_PostId",
                table: "OngHasPostsRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_OngHasPostsRelation_Posts_OngId",
                table: "OngHasPostsRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Ongs_Users_Id",
                table: "Ongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ongs",
                table: "Ongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OngHasPostsRelation",
                table: "OngHasPostsRelation");

            migrationBuilder.RenameTable(
                name: "Ongs",
                newName: "ONGS");

            migrationBuilder.RenameTable(
                name: "OngHasPostsRelation",
                newName: "ONGHasPostsRelation");

            migrationBuilder.RenameColumn(
                name: "OngId",
                table: "Users",
                newName: "ONGId");

            migrationBuilder.RenameColumn(
                name: "NumberStars",
                table: "Review",
                newName: "numberStars");

            migrationBuilder.RenameColumn(
                name: "OngId",
                table: "ONGHasPostsRelation",
                newName: "ONGId");

            migrationBuilder.RenameIndex(
                name: "IX_OngHasPostsRelation_PostId",
                table: "ONGHasPostsRelation",
                newName: "IX_ONGHasPostsRelation_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ONGS",
                table: "ONGS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ONGHasPostsRelation",
                table: "ONGHasPostsRelation",
                columns: new[] { "ONGId", "PostId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ONGHasPostsRelation_ONGS_PostId",
                table: "ONGHasPostsRelation",
                column: "PostId",
                principalTable: "ONGS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ONGHasPostsRelation_Posts_ONGId",
                table: "ONGHasPostsRelation",
                column: "ONGId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ONGS_Users_Id",
                table: "ONGS",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
