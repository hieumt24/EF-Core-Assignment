using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assingment_EFCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addSeedDataDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("13496720-ca1d-43b3-91e0-059a6c4002f7"), "Accountant" },
                    { new Guid("8489dc60-4588-42cc-b1df-e2fa38a942e3"), "HR" },
                    { new Guid("ee670359-0999-4e80-91b5-51cd5c4cff7a"), "Finance" },
                    { new Guid("f598c41b-1fda-4df6-b2b8-65a98e53b153"), "Software Development" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("13496720-ca1d-43b3-91e0-059a6c4002f7"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("8489dc60-4588-42cc-b1df-e2fa38a942e3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ee670359-0999-4e80-91b5-51cd5c4cff7a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f598c41b-1fda-4df6-b2b8-65a98e53b153"));
        }
    }
}
