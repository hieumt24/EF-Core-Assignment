using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assingment_EFCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addnewProejct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("07edf3e4-3ccc-44c9-9923-9e51a121efe0"), "Customer Service" },
                    { new Guid("33ab29e9-d256-4b4d-b233-6ce22c3625e1"), "Accountant" },
                    { new Guid("55a0dd42-ea2f-4454-8a31-0e0fe6439fd0"), "Sales" },
                    { new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"), "Software Development" },
                    { new Guid("e8952de1-f579-486a-99d5-a8218d8374e8"), "Marketing" },
                    { new Guid("f1ff5038-dccf-4ae3-9526-304b76e03553"), "Finance" },
                    { new Guid("f614c858-1bcb-4bd3-beed-956560d4dfcd"), "HR" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bb86571-364b-4d8e-b59d-ba4e4dd55b8b"), "Project D" },
                    { new Guid("4fdf3b0f-aaab-4655-b55b-9e2e09d8822e"), "Project E" },
                    { new Guid("518ae6c2-506f-4f98-9841-52ad994a1ad2"), "Project B" },
                    { new Guid("5c735561-7a2c-47e0-85b6-e1dad02cb350"), "Project A" },
                    { new Guid("aa3b8480-0349-427a-99f7-3c345ad8f3fa"), "Project C" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "IsDeleted", "JoinedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("14fee08b-ab6e-4759-929a-0b147c8e19ff"), new Guid("f1ff5038-dccf-4ae3-9526-304b76e03553"), false, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van B" },
                    { new Guid("1ed28244-29c0-4881-9964-b0dc5237a310"), new Guid("55a0dd42-ea2f-4454-8a31-0e0fe6439fd0"), false, new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van F" },
                    { new Guid("4ccdb5a9-ade2-4797-97cc-fa551ff2b91e"), new Guid("e8952de1-f579-486a-99d5-a8218d8374e8"), false, new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van E" },
                    { new Guid("5eaf9267-2f42-4bb7-9dde-9b3674da71ba"), new Guid("f614c858-1bcb-4bd3-beed-956560d4dfcd"), false, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van K" },
                    { new Guid("6c058439-6cb1-4e61-bfb8-0191095b5e93"), new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"), false, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van A" },
                    { new Guid("87d5fac3-2cd1-4c83-9bf2-fc65c00de0ee"), new Guid("f1ff5038-dccf-4ae3-9526-304b76e03553"), false, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van I" },
                    { new Guid("95e73d54-81f8-47f7-830c-da1e42484b4d"), new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"), false, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van H" },
                    { new Guid("cb92e359-c100-4f27-85ae-68c32b5cab34"), new Guid("07edf3e4-3ccc-44c9-9923-9e51a121efe0"), false, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van G" },
                    { new Guid("ddc70bce-98e9-4152-a92d-117ddd8997aa"), new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"), false, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van C" },
                    { new Guid("f76fafce-2021-40f2-b163-368d9fa7c600"), new Guid("f614c858-1bcb-4bd3-beed-956560d4dfcd"), false, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van D" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("33ab29e9-d256-4b4d-b233-6ce22c3625e1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("14fee08b-ab6e-4759-929a-0b147c8e19ff"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1ed28244-29c0-4881-9964-b0dc5237a310"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4ccdb5a9-ade2-4797-97cc-fa551ff2b91e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5eaf9267-2f42-4bb7-9dde-9b3674da71ba"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6c058439-6cb1-4e61-bfb8-0191095b5e93"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("87d5fac3-2cd1-4c83-9bf2-fc65c00de0ee"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("95e73d54-81f8-47f7-830c-da1e42484b4d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cb92e359-c100-4f27-85ae-68c32b5cab34"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ddc70bce-98e9-4152-a92d-117ddd8997aa"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f76fafce-2021-40f2-b163-368d9fa7c600"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("0bb86571-364b-4d8e-b59d-ba4e4dd55b8b"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("4fdf3b0f-aaab-4655-b55b-9e2e09d8822e"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("518ae6c2-506f-4f98-9841-52ad994a1ad2"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("5c735561-7a2c-47e0-85b6-e1dad02cb350"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("aa3b8480-0349-427a-99f7-3c345ad8f3fa"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("07edf3e4-3ccc-44c9-9923-9e51a121efe0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("55a0dd42-ea2f-4454-8a31-0e0fe6439fd0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e8952de1-f579-486a-99d5-a8218d8374e8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f1ff5038-dccf-4ae3-9526-304b76e03553"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f614c858-1bcb-4bd3-beed-956560d4dfcd"));

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
    }
}
