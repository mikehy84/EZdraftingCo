using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class emailTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "EmailAddresses",
                newName: "EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_EmailAddresses_PersonId_Email",
                table: "EmailAddresses",
                newName: "IX_EmailAddresses_PersonId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_EmailAddresses_Email",
                table: "EmailAddresses",
                newName: "IX_EmailAddresses_EmailAddress");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 225, DateTimeKind.Utc).AddTicks(5692), new DateTime(2026, 2, 10, 2, 11, 17, 225, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 225, DateTimeKind.Utc).AddTicks(5696), new DateTime(2026, 2, 10, 2, 11, 17, 225, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "AssignedRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AssignedAt",
                value: new DateTime(2026, 2, 10, 2, 11, 17, 228, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "AssignedRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AssignedAt",
                value: new DateTime(2026, 2, 10, 2, 11, 17, 228, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "ClientProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 229, DateTimeKind.Utc).AddTicks(2460), new DateTime(2026, 2, 10, 2, 11, 17, 229, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "ClientProjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 229, DateTimeKind.Utc).AddTicks(2463), new DateTime(2026, 2, 10, 2, 11, 17, 229, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 9, 18, 11, 17, 230, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 9, 18, 11, 17, 230, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 231, DateTimeKind.Utc).AddTicks(3277), new DateTime(2026, 2, 10, 2, 11, 17, 231, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 231, DateTimeKind.Utc).AddTicks(3280), new DateTime(2026, 2, 10, 2, 11, 17, 231, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 231, DateTimeKind.Utc).AddTicks(9579), new DateTime(2026, 2, 10, 2, 11, 17, 231, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 231, DateTimeKind.Utc).AddTicks(9582), new DateTime(2026, 2, 10, 2, 11, 17, 231, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 232, DateTimeKind.Utc).AddTicks(7784), new DateTime(2026, 2, 10, 2, 11, 17, 232, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 232, DateTimeKind.Utc).AddTicks(7788), new DateTime(2026, 2, 10, 2, 11, 17, 232, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "TaskAssignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 235, DateTimeKind.Utc).AddTicks(8623), new DateTime(2026, 2, 10, 2, 11, 17, 235, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "TaskAssignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 235, DateTimeKind.Utc).AddTicks(8626), new DateTime(2026, 2, 10, 2, 11, 17, 235, DateTimeKind.Utc).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "TaskDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(810), new DateTime(2026, 2, 20, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(808), new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "TaskDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(815), new DateTime(2026, 2, 25, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(814), new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(3159), new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(3162), new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(3165), new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(3167), new DateTime(2026, 2, 10, 2, 11, 17, 237, DateTimeKind.Utc).AddTicks(3168) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "EmailAddresses",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_EmailAddresses_PersonId_EmailAddress",
                table: "EmailAddresses",
                newName: "IX_EmailAddresses_PersonId_Email");

            migrationBuilder.RenameIndex(
                name: "IX_EmailAddresses_EmailAddress",
                table: "EmailAddresses",
                newName: "IX_EmailAddresses_Email");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 887, DateTimeKind.Utc).AddTicks(177), new DateTime(2026, 1, 5, 5, 35, 27, 887, DateTimeKind.Utc).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 887, DateTimeKind.Utc).AddTicks(181), new DateTime(2026, 1, 5, 5, 35, 27, 887, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "AssignedRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AssignedAt",
                value: new DateTime(2026, 1, 5, 5, 35, 27, 890, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "AssignedRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AssignedAt",
                value: new DateTime(2026, 1, 5, 5, 35, 27, 890, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "ClientProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 890, DateTimeKind.Utc).AddTicks(8645), new DateTime(2026, 1, 5, 5, 35, 27, 890, DateTimeKind.Utc).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "ClientProjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 890, DateTimeKind.Utc).AddTicks(8648), new DateTime(2026, 1, 5, 5, 35, 27, 890, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 4, 21, 35, 27, 891, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 4, 21, 35, 27, 891, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 893, DateTimeKind.Utc).AddTicks(5231), new DateTime(2026, 1, 5, 5, 35, 27, 893, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 893, DateTimeKind.Utc).AddTicks(5234), new DateTime(2026, 1, 5, 5, 35, 27, 893, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 894, DateTimeKind.Utc).AddTicks(1784), new DateTime(2026, 1, 5, 5, 35, 27, 894, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 894, DateTimeKind.Utc).AddTicks(1787), new DateTime(2026, 1, 5, 5, 35, 27, 894, DateTimeKind.Utc).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 894, DateTimeKind.Utc).AddTicks(9595), new DateTime(2026, 1, 5, 5, 35, 27, 894, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 894, DateTimeKind.Utc).AddTicks(9599), new DateTime(2026, 1, 5, 5, 35, 27, 894, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "TaskAssignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 898, DateTimeKind.Utc).AddTicks(3650), new DateTime(2026, 1, 5, 5, 35, 27, 898, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "TaskAssignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 898, DateTimeKind.Utc).AddTicks(3653), new DateTime(2026, 1, 5, 5, 35, 27, 898, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "TaskDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 899, DateTimeKind.Utc).AddTicks(6016), new DateTime(2026, 1, 15, 5, 35, 27, 899, DateTimeKind.Utc).AddTicks(6013), new DateTime(2026, 1, 5, 5, 35, 27, 899, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "TaskDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 899, DateTimeKind.Utc).AddTicks(6020), new DateTime(2026, 1, 20, 5, 35, 27, 899, DateTimeKind.Utc).AddTicks(6020), new DateTime(2026, 1, 5, 5, 35, 27, 899, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 900, DateTimeKind.Utc).AddTicks(90), new DateTime(2026, 1, 5, 5, 35, 27, 900, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 900, DateTimeKind.Utc).AddTicks(94), new DateTime(2026, 1, 5, 5, 35, 27, 900, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 900, DateTimeKind.Utc).AddTicks(97), new DateTime(2026, 1, 5, 5, 35, 27, 900, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 5, 5, 35, 27, 900, DateTimeKind.Utc).AddTicks(100), new DateTime(2026, 1, 5, 5, 35, 27, 900, DateTimeKind.Utc).AddTicks(101) });
        }
    }
}
