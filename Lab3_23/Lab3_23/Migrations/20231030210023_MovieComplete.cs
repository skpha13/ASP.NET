using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3_23.Migrations
{
    /// <inheritdoc />
    public partial class MovieComplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateTime", "LastModified", "description", "duration", "name", "rating" },
                values: new object[] { new Guid("3d4ef717-1202-4c13-a3ac-6ac4fa4a74c7"), null, null, null, 76.5f, "Scream", 9 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3d4ef717-1202-4c13-a3ac-6ac4fa4a74c7"));
        }
    }
}
