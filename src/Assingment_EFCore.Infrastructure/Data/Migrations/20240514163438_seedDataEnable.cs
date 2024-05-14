using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assingment_EFCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDataEnable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("077caa19-4752-4e32-a050-89b9c8d00672"), "Finance" },
                    { new Guid("14d224a2-b38c-40c8-9043-6b9a0b970d4d"), "Customer Service" },
                    { new Guid("204727bc-d435-45ad-bcac-05a752e19b42"), "Marketing" },
                    { new Guid("44c91649-c8b6-4bbe-8d70-a9b3e6068703"), "HR" },
                    { new Guid("704a08d9-3b65-4d90-b55e-9c9bb3c09c39"), "Accountant" },
                    { new Guid("88f10de2-ec3c-4c8e-bce6-4c42fbbbe2e1"), "Sales" },
                    { new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"), "Software Development" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1fa11c89-5d1d-448c-961c-19455e1841af"), "Project F" },
                    { new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"), "Project C" },
                    { new Guid("3483cd91-651e-4a40-8505-1d24d733764d"), "Project E" },
                    { new Guid("57839bbc-e60f-4e33-a4da-c336a86799ae"), "Project D" },
                    { new Guid("bc5e777e-265c-4964-aa59-708076744a3a"), "Project B" },
                    { new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"), "Project A" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "IsDeleted", "JoinedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2f27c155-d28d-4a8c-9edd-dfd928c945e3"), new Guid("14d224a2-b38c-40c8-9043-6b9a0b970d4d"), false, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van G" },
                    { new Guid("32ab0fa0-0759-44de-b7a3-186942f4484f"), new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"), false, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van H" },
                    { new Guid("48b448b3-299a-485e-8c70-48967185ac04"), new Guid("077caa19-4752-4e32-a050-89b9c8d00672"), false, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van B" },
                    { new Guid("6a18e901-c6e0-4d8d-90e6-2b1d4e3d5ef5"), new Guid("077caa19-4752-4e32-a050-89b9c8d00672"), false, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van I" },
                    { new Guid("72814f03-70cb-4d9a-8541-1f713fc6762e"), new Guid("44c91649-c8b6-4bbe-8d70-a9b3e6068703"), false, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van D" },
                    { new Guid("73def274-5e7c-4476-881c-46c7bb428938"), new Guid("204727bc-d435-45ad-bcac-05a752e19b42"), false, new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van E" },
                    { new Guid("7c55e16a-6c45-4a95-948a-2c52b3f3c7ad"), new Guid("88f10de2-ec3c-4c8e-bce6-4c42fbbbe2e1"), false, new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van F" },
                    { new Guid("94b9dd0b-0b4a-4a80-9b0c-f2d04824c70d"), new Guid("44c91649-c8b6-4bbe-8d70-a9b3e6068703"), false, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van K" },
                    { new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"), new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"), false, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van C" },
                    { new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"), new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"), false, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van A" }
                });

            migrationBuilder.InsertData(
                table: "ProjectEmployees",
                columns: new[] { "EmployeeId", "ProjectId", "Enable" },
                values: new object[,]
                {
                    { new Guid("48b448b3-299a-485e-8c70-48967185ac04"), new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"), true },
                    { new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"), new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"), true },
                    { new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"), new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"), true },
                    { new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"), new Guid("bc5e777e-265c-4964-aa59-708076744a3a"), true },
                    { new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"), new Guid("bc5e777e-265c-4964-aa59-708076744a3a"), true },
                    { new Guid("48b448b3-299a-485e-8c70-48967185ac04"), new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"), true },
                    { new Guid("72814f03-70cb-4d9a-8541-1f713fc6762e"), new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"), true },
                    { new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"), new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"), true },
                    { new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"), new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"), true }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Id", "EmployeeId", "SalaryAmount" },
                values: new object[,]
                {
                    { new Guid("0cf5af08-2b13-42cd-b340-0617861779ed"), new Guid("48b448b3-299a-485e-8c70-48967185ac04"), 2000m },
                    { new Guid("26cda848-e8d1-40a4-b5ee-544e16f68443"), new Guid("6a18e901-c6e0-4d8d-90e6-2b1d4e3d5ef5"), 9000m },
                    { new Guid("33463341-1720-43d1-9ca7-237653e7eec0"), new Guid("2f27c155-d28d-4a8c-9edd-dfd928c945e3"), 7000m },
                    { new Guid("55464761-c00c-4da4-9eee-63175586670f"), new Guid("7c55e16a-6c45-4a95-948a-2c52b3f3c7ad"), 6000m },
                    { new Guid("5a569bfd-a7fb-498c-8d82-b56b653478a5"), new Guid("73def274-5e7c-4476-881c-46c7bb428938"), 5000m },
                    { new Guid("62947484-15b8-4c31-863f-2f10161e9c8a"), new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"), 3000m },
                    { new Guid("8c42be0d-e8b1-4f8a-a8d8-19fc52cb9fce"), new Guid("94b9dd0b-0b4a-4a80-9b0c-f2d04824c70d"), 10000m },
                    { new Guid("a9f2c783-795d-4e4f-92c8-4b830f721d6f"), new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"), 1000m },
                    { new Guid("addee1fb-90bd-48d6-bc82-b1ba3f658102"), new Guid("32ab0fa0-0759-44de-b7a3-186942f4484f"), 8000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("704a08d9-3b65-4d90-b55e-9c9bb3c09c39"));

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("48b448b3-299a-485e-8c70-48967185ac04"), new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"), new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"), new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"), new Guid("bc5e777e-265c-4964-aa59-708076744a3a") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"), new Guid("bc5e777e-265c-4964-aa59-708076744a3a") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("48b448b3-299a-485e-8c70-48967185ac04"), new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("72814f03-70cb-4d9a-8541-1f713fc6762e"), new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"), new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54") });

            migrationBuilder.DeleteData(
                table: "ProjectEmployees",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"), new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54") });

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("1fa11c89-5d1d-448c-961c-19455e1841af"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("3483cd91-651e-4a40-8505-1d24d733764d"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("57839bbc-e60f-4e33-a4da-c336a86799ae"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("0cf5af08-2b13-42cd-b340-0617861779ed"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("26cda848-e8d1-40a4-b5ee-544e16f68443"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("33463341-1720-43d1-9ca7-237653e7eec0"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("55464761-c00c-4da4-9eee-63175586670f"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("5a569bfd-a7fb-498c-8d82-b56b653478a5"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("62947484-15b8-4c31-863f-2f10161e9c8a"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("8c42be0d-e8b1-4f8a-a8d8-19fc52cb9fce"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("a9f2c783-795d-4e4f-92c8-4b830f721d6f"));

            migrationBuilder.DeleteData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: new Guid("addee1fb-90bd-48d6-bc82-b1ba3f658102"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2f27c155-d28d-4a8c-9edd-dfd928c945e3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("32ab0fa0-0759-44de-b7a3-186942f4484f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("48b448b3-299a-485e-8c70-48967185ac04"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6a18e901-c6e0-4d8d-90e6-2b1d4e3d5ef5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("72814f03-70cb-4d9a-8541-1f713fc6762e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("73def274-5e7c-4476-881c-46c7bb428938"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7c55e16a-6c45-4a95-948a-2c52b3f3c7ad"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("94b9dd0b-0b4a-4a80-9b0c-f2d04824c70d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("bc5e777e-265c-4964-aa59-708076744a3a"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("077caa19-4752-4e32-a050-89b9c8d00672"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("14d224a2-b38c-40c8-9043-6b9a0b970d4d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("204727bc-d435-45ad-bcac-05a752e19b42"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("44c91649-c8b6-4bbe-8d70-a9b3e6068703"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("88f10de2-ec3c-4c8e-bce6-4c42fbbbe2e1"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"));

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
    }
}
