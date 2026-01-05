using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class taskLogTableRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskLogs");

            migrationBuilder.AddColumn<int>(
                name: "TaskStateId",
                table: "TaskDetails",
                type: "int",
                nullable: false,
                defaultValue: 1);

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

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetails_TaskStateId",
                table: "TaskDetails",
                column: "TaskStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDetails_TaskStates_TaskStateId",
                table: "TaskDetails",
                column: "TaskStateId",
                principalTable: "TaskStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskDetails_TaskStates_TaskStateId",
                table: "TaskDetails");

            migrationBuilder.DropIndex(
                name: "IX_TaskDetails_TaskStateId",
                table: "TaskDetails");

            migrationBuilder.DropColumn(
                name: "TaskStateId",
                table: "TaskDetails");

            migrationBuilder.CreateTable(
                name: "TaskLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskDetailId = table.Column<int>(type: "int", nullable: false),
                    TaskStateId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskLogs_TaskDetails_TaskDetailId",
                        column: x => x.TaskDetailId,
                        principalTable: "TaskDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskLogs_TaskStates_TaskStateId",
                        column: x => x.TaskStateId,
                        principalTable: "TaskStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 288, DateTimeKind.Utc).AddTicks(8207), new DateTime(2025, 12, 28, 7, 42, 39, 288, DateTimeKind.Utc).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 288, DateTimeKind.Utc).AddTicks(8211), new DateTime(2025, 12, 28, 7, 42, 39, 288, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "AssignedRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AssignedAt",
                value: new DateTime(2025, 12, 28, 7, 42, 39, 292, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "AssignedRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "AssignedAt",
                value: new DateTime(2025, 12, 28, 7, 42, 39, 292, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "ClientProjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 293, DateTimeKind.Utc).AddTicks(2173), new DateTime(2025, 12, 28, 7, 42, 39, 293, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "ClientProjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 293, DateTimeKind.Utc).AddTicks(2176), new DateTime(2025, 12, 28, 7, 42, 39, 293, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 23, 42, 39, 293, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 27, 23, 42, 39, 293, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 295, DateTimeKind.Utc).AddTicks(3365), new DateTime(2025, 12, 28, 7, 42, 39, 295, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 295, DateTimeKind.Utc).AddTicks(3368), new DateTime(2025, 12, 28, 7, 42, 39, 295, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 295, DateTimeKind.Utc).AddTicks(9666), new DateTime(2025, 12, 28, 7, 42, 39, 295, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 295, DateTimeKind.Utc).AddTicks(9668), new DateTime(2025, 12, 28, 7, 42, 39, 295, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 296, DateTimeKind.Utc).AddTicks(7102), new DateTime(2025, 12, 28, 7, 42, 39, 296, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 296, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 12, 28, 7, 42, 39, 296, DateTimeKind.Utc).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "TaskAssignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 299, DateTimeKind.Utc).AddTicks(9745), new DateTime(2025, 12, 28, 7, 42, 39, 299, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "TaskAssignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 299, DateTimeKind.Utc).AddTicks(9749), new DateTime(2025, 12, 28, 7, 42, 39, 299, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "TaskDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 300, DateTimeKind.Utc).AddTicks(9334), new DateTime(2026, 1, 7, 7, 42, 39, 300, DateTimeKind.Utc).AddTicks(9332), new DateTime(2025, 12, 28, 7, 42, 39, 300, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "TaskDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 300, DateTimeKind.Utc).AddTicks(9338), new DateTime(2026, 1, 12, 7, 42, 39, 300, DateTimeKind.Utc).AddTicks(9337), new DateTime(2025, 12, 28, 7, 42, 39, 300, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.InsertData(
                table: "TaskLogs",
                columns: new[] { "Id", "CreatedAt", "TaskDetailId", "TaskStateId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(1622), 1, 1, new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(1624) },
                    { 2, new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(1627), 2, 1, new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(1627) }
                });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(3897), new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(3901), new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(3903), new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "TaskProgresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(3906), new DateTime(2025, 12, 28, 7, 42, 39, 301, DateTimeKind.Utc).AddTicks(3906) });

            migrationBuilder.CreateIndex(
                name: "IX_TaskLogs_TaskDetailId",
                table: "TaskLogs",
                column: "TaskDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskLogs_TaskStateId",
                table: "TaskLogs",
                column: "TaskStateId");
        }
    }
}
