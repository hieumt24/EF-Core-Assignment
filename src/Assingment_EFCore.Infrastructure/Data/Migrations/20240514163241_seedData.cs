using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assingment_EFCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("04f3e8dd-cb05-45d8-93ef-79f0c76fb157"), "HR" },
                    { new Guid("29087b5a-b92d-42e3-893a-473834f5e159"), "Accountant" },
                    { new Guid("4ec90559-8555-4362-861b-2dc4c62c985d"), "Customer Service" },
                    { new Guid("548950c1-ee83-4779-b33d-da9cea90f84b"), "Sales" },
                    { new Guid("5b65bb02-649b-4146-bd5b-1f8ef0df6e40"), "Marketing" },
                    { new Guid("6b7b3483-c21f-4a9b-adf1-b330a38dd5c1"), "Finance" },
                    { new Guid("c4094b0a-a176-4a69-8c58-4da91822e1e8"), "Software Development" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("140bb413-7d2b-43e2-83df-34a7e9bcb0d1"), "Project B" },
                    { new Guid("432b6aeb-ffd7-436b-87be-b3c176edd0fe"), "Project C" },
                    { new Guid("4b310467-0dec-4042-8980-d155e01ed6a3"), "Project E" },
                    { new Guid("a1a73d40-e4d3-4385-9d5f-6384fc42806f"), "Project D" },
                    { new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367"), "Project A" },
                    { new Guid("c495897d-5c27-422c-a0ef-dadaa5de71c4"), "Project F" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "IsDeleted", "JoinedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("17fd1ab1-ceb2-4ac0-894f-bea653987208"), new Guid("548950c1-ee83-4779-b33d-da9cea90f84b"), false, new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van F" },
                    { new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"), new Guid("c4094b0a-a176-4a69-8c58-4da91822e1e8"), false, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van C" },
                    { new Guid("5ce93518-74c5-4327-8903-bbb36f0f4cc2"), new Guid("6b7b3483-c21f-4a9b-adf1-b330a38dd5c1"), false, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van B" },
                    { new Guid("7ed886d3-a340-4974-bc4e-cba987c184c4"), new Guid("04f3e8dd-cb05-45d8-93ef-79f0c76fb157"), false, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van K" },
                    { new Guid("8bf79edb-5e3f-4b16-b4cb-1dfbc261f918"), new Guid("4ec90559-8555-4362-861b-2dc4c62c985d"), false, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van G" },
                    { new Guid("8e407c3b-ffcf-4dc9-a9cd-084140b6c876"), new Guid("6b7b3483-c21f-4a9b-adf1-b330a38dd5c1"), false, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van I" },
                    { new Guid("932dab03-d560-41f7-b474-ea95aef5b70d"), new Guid("c4094b0a-a176-4a69-8c58-4da91822e1e8"), false, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van H" },
                    { new Guid("b6737c5f-7ca2-4bb2-a632-4a46b50a34e5"), new Guid("04f3e8dd-cb05-45d8-93ef-79f0c76fb157"), false, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van D" },
                    { new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"), new Guid("c4094b0a-a176-4a69-8c58-4da91822e1e8"), false, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van A" },
                    { new Guid("fb587bed-3bae-4568-a4b5-ff432dc867c2"), new Guid("5b65bb02-649b-4146-bd5b-1f8ef0df6e40"), false, new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van E" }
                });

            migrationBuilder.InsertData(
                table: "ProjectEmployees",
                columns: new[] { "EmployeeId", "ProjectId", "Enable" },
                values: new object[,]
                {
                    { new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"), new Guid("140bb413-7d2b-43e2-83df-34a7e9bcb0d1"), false },
                    { new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"), new Guid("140bb413-7d2b-43e2-83df-34a7e9bcb0d1"), false },
                    { new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"), new Guid("432b6aeb-ffd7-436b-87be-b3c176edd0fe"), false },
                    { new Guid("5ce93518-74c5-4327-8903-bbb36f0f4cc2"), new Guid("432b6aeb-ffd7-436b-87be-b3c176edd0fe"), false },
                    { new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"), new Guid("432b6aeb-ffd7-436b-87be-b3c176edd0fe"), false },
                    { new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"), new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367"), false },
                    { new Guid("5ce93518-74c5-4327-8903-bbb36f0f4cc2"), new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367"), false },
                    { new Guid("b6737c5f-7ca2-4bb2-a632-4a46b50a34e5"), new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367"), false },
                    { new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"), new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367"), false }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "EmployeeId", "SalaryAmount" },
                values: new object[,]
                {
                    { new Guid("2a1b051d-59ba-4cc7-ac95-90fece4627e1"), new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"), 3000m },
                    { new Guid("3fb29652-816f-4008-b9f6-941576dc4079"), new Guid("fb587bed-3bae-4568-a4b5-ff432dc867c2"), 5000m },
                    { new Guid("4c749232-b2b2-49f6-9f49-ac8b25c2c608"), new Guid("8e407c3b-ffcf-4dc9-a9cd-084140b6c876"), 9000m },
                    { new Guid("76ebcf61-c29d-45d8-8a52-c95d4639e6cc"), new Guid("5ce93518-74c5-4327-8903-bbb36f0f4cc2"), 2000m },
                    { new Guid("950653cc-e8c0-46dc-947c-981e8f611401"), new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"), 1000m },
                    { new Guid("97e3adce-adac-4580-90dc-d1269628aab9"), new Guid("932dab03-d560-41f7-b474-ea95aef5b70d"), 8000m },
                    { new Guid("be1e2b7a-f132-4ee7-b0af-ed6a10bc7712"), new Guid("8bf79edb-5e3f-4b16-b4cb-1dfbc261f918"), 7000m },
                    { new Guid("f01b3e23-8cb4-4402-a1d8-ca47b399550e"), new Guid("7ed886d3-a340-4974-bc4e-cba987c184c4"), 10000m },
                    { new Guid("f82ef0e0-624d-4fb9-9ea8-8911badf2464"), new Guid("17fd1ab1-ceb2-4ac0-894f-bea653987208"), 6000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("29087b5a-b92d-42e3-893a-473834f5e159"));

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"), new Guid("140bb413-7d2b-43e2-83df-34a7e9bcb0d1") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"), new Guid("140bb413-7d2b-43e2-83df-34a7e9bcb0d1") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"), new Guid("432b6aeb-ffd7-436b-87be-b3c176edd0fe") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("5ce93518-74c5-4327-8903-bbb36f0f4cc2"), new Guid("432b6aeb-ffd7-436b-87be-b3c176edd0fe") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"), new Guid("432b6aeb-ffd7-436b-87be-b3c176edd0fe") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"), new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("5ce93518-74c5-4327-8903-bbb36f0f4cc2"), new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("b6737c5f-7ca2-4bb2-a632-4a46b50a34e5"), new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"), new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367") });

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("4b310467-0dec-4042-8980-d155e01ed6a3"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("a1a73d40-e4d3-4385-9d5f-6384fc42806f"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("c495897d-5c27-422c-a0ef-dadaa5de71c4"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("2a1b051d-59ba-4cc7-ac95-90fece4627e1"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("3fb29652-816f-4008-b9f6-941576dc4079"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("4c749232-b2b2-49f6-9f49-ac8b25c2c608"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("76ebcf61-c29d-45d8-8a52-c95d4639e6cc"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("950653cc-e8c0-46dc-947c-981e8f611401"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("97e3adce-adac-4580-90dc-d1269628aab9"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("be1e2b7a-f132-4ee7-b0af-ed6a10bc7712"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("f01b3e23-8cb4-4402-a1d8-ca47b399550e"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("f82ef0e0-624d-4fb9-9ea8-8911badf2464"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("17fd1ab1-ceb2-4ac0-894f-bea653987208"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("588ff0ad-76fb-409f-9ab7-e2934427fcd1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5ce93518-74c5-4327-8903-bbb36f0f4cc2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7ed886d3-a340-4974-bc4e-cba987c184c4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8bf79edb-5e3f-4b16-b4cb-1dfbc261f918"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8e407c3b-ffcf-4dc9-a9cd-084140b6c876"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("932dab03-d560-41f7-b474-ea95aef5b70d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b6737c5f-7ca2-4bb2-a632-4a46b50a34e5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f232dbad-0de4-43c3-9aa5-96c4193a4846"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fb587bed-3bae-4568-a4b5-ff432dc867c2"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("140bb413-7d2b-43e2-83df-34a7e9bcb0d1"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("432b6aeb-ffd7-436b-87be-b3c176edd0fe"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("c1a9f06a-1f52-4fc7-92c6-ad42370c7367"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("04f3e8dd-cb05-45d8-93ef-79f0c76fb157"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("4ec90559-8555-4362-861b-2dc4c62c985d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("548950c1-ee83-4779-b33d-da9cea90f84b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5b65bb02-649b-4146-bd5b-1f8ef0df6e40"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6b7b3483-c21f-4a9b-adf1-b330a38dd5c1"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c4094b0a-a176-4a69-8c58-4da91822e1e8"));

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
    }
}
