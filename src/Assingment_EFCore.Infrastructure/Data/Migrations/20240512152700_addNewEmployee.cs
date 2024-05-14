using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assingment_EFCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addNewEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1f74eab3-27eb-4c04-b377-ed2e189a618e"), "Software Development" },
                    { new Guid("44f9fc89-f681-4510-bd67-c73b2aba48f0"), "Customer Service" },
                    { new Guid("86f92c7a-eb39-4b1a-8e4c-c0a94dd8f718"), "Marketing" },
                    { new Guid("bbd48c93-dfdc-4534-ab9b-d6ba336de738"), "Sales" },
                    { new Guid("c31519e9-d0ad-4774-8ee6-b3dc0af06c3e"), "Accountant" },
                    { new Guid("d88d1998-c114-4fcb-bc2f-b7542eb8a1be"), "Finance" },
                    { new Guid("fe0e11e5-5fa9-496b-a09b-b268769244c2"), "HR" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "IsDeleted", "JoinedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0298495a-0446-49ce-af03-adc56ded3d53"), new Guid("86f92c7a-eb39-4b1a-8e4c-c0a94dd8f718"), false, new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van E" },
                    { new Guid("573bd61d-6ec0-40e0-aaee-38f01a3d56c5"), new Guid("fe0e11e5-5fa9-496b-a09b-b268769244c2"), false, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van K" },
                    { new Guid("588d98a1-ce76-4736-acda-1f1110f0082a"), new Guid("d88d1998-c114-4fcb-bc2f-b7542eb8a1be"), false, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van B" },
                    { new Guid("5f2b0a9e-f5ca-4478-9574-dd279b0a661d"), new Guid("1f74eab3-27eb-4c04-b377-ed2e189a618e"), false, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van H" },
                    { new Guid("8ad0dc05-9eb7-42db-a69e-7c4857529d08"), new Guid("1f74eab3-27eb-4c04-b377-ed2e189a618e"), false, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van A" },
                    { new Guid("959a1896-4ddf-4f75-9c8f-bd67bf5a720e"), new Guid("44f9fc89-f681-4510-bd67-c73b2aba48f0"), false, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van G" },
                    { new Guid("a7bd8e7c-025d-43ac-ba66-a18dba9052e1"), new Guid("bbd48c93-dfdc-4534-ab9b-d6ba336de738"), false, new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van F" },
                    { new Guid("d295174c-a047-47c3-9e02-ec18874a4938"), new Guid("fe0e11e5-5fa9-496b-a09b-b268769244c2"), false, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van D" },
                    { new Guid("e347b583-7829-4cd2-a641-33a37891fb06"), new Guid("d88d1998-c114-4fcb-bc2f-b7542eb8a1be"), false, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van I" },
                    { new Guid("ec9decad-da1d-4000-a6ff-e2dd0d196826"), new Guid("1f74eab3-27eb-4c04-b377-ed2e189a618e"), false, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van C" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c31519e9-d0ad-4774-8ee6-b3dc0af06c3e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0298495a-0446-49ce-af03-adc56ded3d53"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("573bd61d-6ec0-40e0-aaee-38f01a3d56c5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("588d98a1-ce76-4736-acda-1f1110f0082a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5f2b0a9e-f5ca-4478-9574-dd279b0a661d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8ad0dc05-9eb7-42db-a69e-7c4857529d08"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("959a1896-4ddf-4f75-9c8f-bd67bf5a720e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a7bd8e7c-025d-43ac-ba66-a18dba9052e1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d295174c-a047-47c3-9e02-ec18874a4938"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e347b583-7829-4cd2-a641-33a37891fb06"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ec9decad-da1d-4000-a6ff-e2dd0d196826"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1f74eab3-27eb-4c04-b377-ed2e189a618e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("44f9fc89-f681-4510-bd67-c73b2aba48f0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("86f92c7a-eb39-4b1a-8e4c-c0a94dd8f718"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bbd48c93-dfdc-4534-ab9b-d6ba336de738"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d88d1998-c114-4fcb-bc2f-b7542eb8a1be"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fe0e11e5-5fa9-496b-a09b-b268769244c2"));

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
    }
}
