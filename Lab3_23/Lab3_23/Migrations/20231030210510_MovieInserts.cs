using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab3_23.Migrations
{
    /// <inheritdoc />
    public partial class MovieInserts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3d4ef717-1202-4c13-a3ac-6ac4fa4a74c7"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateTime", "LastModified", "description", "duration", "name", "rating" },
                values: new object[,]
                {
                    { new Guid("1ef520b5-fa13-4b9e-86d2-bb455db9c6e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A movie in which the main actor manages to save the world", 125.3f, "Top Gun: Maverick", 10 },
                    { new Guid("56488344-3799-4a04-ab39-af92ce5e4f89"), null, null, null, 76.5f, "Scream", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1ef520b5-fa13-4b9e-86d2-bb455db9c6e9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("56488344-3799-4a04-ab39-af92ce5e4f89"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateTime", "LastModified", "description", "duration", "name", "rating" },
                values: new object[] { new Guid("3d4ef717-1202-4c13-a3ac-6ac4fa4a74c7"), null, null, null, 76.5f, "Scream", 9 });
        }
    }
}
