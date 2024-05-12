using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assingment_EFCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addnewDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("528e8dc9-6d8a-435b-8170-bb017a1e6ca8"), "Software Development" },
                    { new Guid("5e1c8967-b005-49cc-98f8-9569f9fab8a9"), "Sales" },
                    { new Guid("8914cd02-440b-482d-9418-4f4616647525"), "Accountant" },
                    { new Guid("a14b8840-0115-46e6-b80f-abe78a6be11a"), "Marketing" },
                    { new Guid("af9c551a-3c83-4d2a-8aff-123dfcf8b660"), "HR" },
                    { new Guid("c4d0b1e2-f768-4367-8475-c026a5983df9"), "Finance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("528e8dc9-6d8a-435b-8170-bb017a1e6ca8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5e1c8967-b005-49cc-98f8-9569f9fab8a9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("8914cd02-440b-482d-9418-4f4616647525"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a14b8840-0115-46e6-b80f-abe78a6be11a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("af9c551a-3c83-4d2a-8aff-123dfcf8b660"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c4d0b1e2-f768-4367-8475-c026a5983df9"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

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
    }
}
