using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Created_Date", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 25, 1, 4, 48, 460, DateTimeKind.Local).AddTicks(6360), "Villa 1 Description", "https://via.placeholder.com/150", "Villa 1", 6, 1000.0, 2000, new DateTime(2025, 2, 25, 1, 4, 48, 463, DateTimeKind.Local).AddTicks(3711) },
                    { 2, new DateTime(2025, 2, 25, 1, 4, 48, 463, DateTimeKind.Local).AddTicks(4057), "Villa 2 Description", "https://via.placeholder.com/150", "Villa 2", 8, 2000.0, 3000, new DateTime(2025, 2, 25, 1, 4, 48, 463, DateTimeKind.Local).AddTicks(4066) },
                    { 3, new DateTime(2025, 2, 25, 1, 4, 48, 463, DateTimeKind.Local).AddTicks(4069), "Villa 3 Description", "https://via.placeholder.com/150", "Villa 3", 10, 3000.0, 4000, new DateTime(2025, 2, 25, 1, 4, 48, 463, DateTimeKind.Local).AddTicks(4071) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
