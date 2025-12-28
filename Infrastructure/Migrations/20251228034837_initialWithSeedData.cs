using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialWithSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsoCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    PhoneCode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DeactivatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReactivatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RatePerHour = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    TokenHash = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UsedByAccountId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountClaims_AspNetUsers_UsedByAccountId",
                        column: x => x.UsedByAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_AccountClaims_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssignedRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssigneeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    AssignorId = table.Column<int>(type: "int", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignedRoles_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedRoles_Persons_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedRoles_Persons_AssignorId",
                        column: x => x.AssignorId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientPmId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ProjectNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedHour = table.Column<int>(type: "int", nullable: false),
                    ProjectRate = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AwardedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientProjects_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientProjects_Persons_ClientPmId",
                        column: x => x.ClientPmId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAddresses_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProfiles",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    SinEncrypted = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    SinHash = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SinLast3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfiles", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phones_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phones_PhoneTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "PhoneTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternalProjectNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectManagerId = table.Column<int>(type: "int", nullable: false),
                    ActualHours = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    ClientProjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_ClientProjects_ClientProjectId",
                        column: x => x.ClientProjectId,
                        principalTable: "ClientProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Persons_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    PhaseNumber = table.Column<int>(type: "int", nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phases_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectAreas_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskNameId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: true),
                    PriorityId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    EstimatedHours = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDetails_Phases_PhaseId",
                        column: x => x.PhaseId,
                        principalTable: "Phases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskDetails_Priorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskDetails_ProjectAreas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "ProjectAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_TaskDetails_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskDetails_TaskNames_TaskNameId",
                        column: x => x.TaskNameId,
                        principalTable: "TaskNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskDetailId = table.Column<int>(type: "int", nullable: false),
                    TaskAssignorId = table.Column<int>(type: "int", nullable: false),
                    TaskAssigneeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAssignments_Persons_TaskAssigneeId",
                        column: x => x.TaskAssigneeId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskAssignments_Persons_TaskAssignorId",
                        column: x => x.TaskAssignorId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskAssignments_TaskDetails_TaskDetailId",
                        column: x => x.TaskDetailId,
                        principalTable: "TaskDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "TaskProgresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskAssignmentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpentHours = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskProgresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskProgresses_TaskAssignments_TaskAssignmentId",
                        column: x => x.TaskAssignmentId,
                        principalTable: "TaskAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskProgressId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskComments_TaskProgresses_TaskProgressId",
                        column: x => x.TaskProgressId,
                        principalTable: "TaskProgresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Business owner with high-level oversight across all projects.", "Owner" },
                    { 2, "Internal employee involved in project execution and delivery.", "Employee" },
                    { 3, "Client-side personnel involved in coordination, review, and approvals.", "Client" },
                    { 4, "Main contractor responsible for overall construction execution.", "General Contractor" },
                    { 5, "Specialty contractor working under the general contractor.", "Subcontractor" },
                    { 6, "Material or component supplier participating in coordination.", "Vendor" },
                    { 7, "Steel fabrication company producing shop components.", "Fabricator" },
                    { 8, "Company responsible for on-site steel erection.", "Erector" },
                    { 9, "Engineer, architect, or design consultant.", "Consultant" },
                    { 10, "Third-party or authority inspection role.", "Inspector" },
                    { 11, "View-only access with no modification rights.", "ReadOnly" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Comment", "Type" },
                values: new object[,]
                {
                    { 1, "Our own company or internal branches", "Internal" },
                    { 2, "Project owner or paying client", "Client" },
                    { 3, "Main contractor responsible for construction", "General Contractor" },
                    { 4, "Fabrication shop producing steel members", "Steel Fabricator" },
                    { 5, "Company responsible for site erection", "Steel Erector" },
                    { 6, "Engineering, architectural, or design consultant", "Consultant" },
                    { 7, "Material or component supplier", "Vendor" },
                    { 8, "Specialty contractor under main contract", "Subcontractor" },
                    { 9, "Third-party or authority inspection body", "Inspector" },
                    { 10, "Regulatory or permitting authority", "Authority" },
                    { 11, "Strategic or long-term collaborator", "Partner" },
                    { 12, "Transport / delivery companies", "Logistics" },
                    { 13, "IT supports", "IT" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "IsoCode", "Name", "PhoneCode" },
                values: new object[,]
                {
                    { 1, "US", "United States", "+1" },
                    { 2, "CA", "Canada", "+1" },
                    { 3, "GB", "United Kingdom", "+44" },
                    { 4, "AU", "Australia", "+61" },
                    { 5, "DE", "Germany", "+49" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "General manager", "Manager" },
                    { 2, "Entry-level detailer with 1–2 years of experience under supervision.", "Junior Detailer" },
                    { 3, "Detailer with solid Tekla experience handling standard projects independently.", "Intermediate Detailer" },
                    { 4, "Experienced detailer responsible for complex steel structures and quality control.", "Senior Detailer" },
                    { 5, "Leads detailing teams, coordinates workflow, and ensures drawing standards.", "Lead Detailer" },
                    { 6, "Manages detailing projects, client communication, and delivery milestones.", "Project Manager" },
                    { 7, "Reviews shop drawings for accuracy, standards, and constructability.", "Checker" },
                    { 8, "Entry-level drafter assisting with drawings, markups, and basic Tekla outputs.", "Junior Drafter" },
                    { 9, "Produces shop drawings independently under guidance, with solid Tekla drafting skills.", "Intermediate Drafter" },
                    { 10, "Handles complex drawings, coordinates revisions, and supports detailing quality.", "Senior Drafter" },
                    { 11, "Client-side project manager overseeing scope, schedule, and approvals.", "Client Project Manager" },
                    { 12, "Primary client contact responsible for coordination and communication.", "Client Representative" },
                    { 13, "Client-side engineer reviewing drawings, RFIs, and technical submissions.", "Client Engineer" },
                    { 14, "Represents the client on site and coordinates construction activities.", "Client Site Manager" },
                    { 15, "Reviews quality, compliance, and drawing accuracy on behalf of the client.", "Client QA/QC" },
                    { 16, "Supports client project team with documentation, schedules, and submissions.", "Client Coordinator" }
                });

            migrationBuilder.InsertData(
                table: "PhoneTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Mobile" },
                    { 2, "Work" },
                    { 3, "Home" },
                    { 4, "Office" },
                    { 5, "Fax" },
                    { 6, "Emergency" },
                    { 7, "Site" },
                    { 8, "After Hours" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Definition", "Name" },
                values: new object[,]
                {
                    { 1, "High risk of incorrect fabrication; Stop current taks; Fix immediately", "Urgent" },
                    { 2, "Important detailing task or issue; should be addressed soon", "High" },
                    { 3, "Normal detailing task or issue", "Medium" },
                    { 4, "Minor detailing task or issue", "Low" },
                    { 5, "Cosmetic or documentation-only issue with no production impact", "Trivial" }
                });

            migrationBuilder.InsertData(
                table: "TaskNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Back Drafting_E Plans" },
                    { 2, "Back Drafting_Shop Dwgs" },
                    { 3, "Checking" },
                    { 4, "Connecting" },
                    { 5, "Editing" },
                    { 6, "Erection Drawings" },
                    { 7, "Modeling" },
                    { 8, "Project Management" }
                });

            migrationBuilder.InsertData(
                table: "TaskStates",
                columns: new[] { "Id", "Definition", "Name" },
                values: new object[,]
                {
                    { 1, "Task created but not started yet", "New" },
                    { 2, "Actively being worked on", "In Progress" },
                    { 3, "Temporarily stopped by choice (not blocked)", "Paused" },
                    { 4, "No longer required", "Cancelled" },
                    { 5, "Blocked, waiting for input (RFI, approval, info)", "On Hold" },
                    { 6, "Work finished and ready for review", "Completed" },
                    { 7, "Approved / accepted, no further action", "Closed" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyTypeId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Quality Drafting Company" },
                    { 2, 13, "Innovatech Corp." },
                    { 3, 7, "Global Dynamics Inc." }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Code", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "AB", 1, "Alberta" },
                    { 2, "BC", 1, "British Columbia" },
                    { 3, "MB", 1, "Manitoba" },
                    { 4, "NB", 1, "New Brunswick" },
                    { 5, "NL", 1, "Newfoundland and Labrador" },
                    { 6, "NS", 1, "Nova Scotia" },
                    { 7, "NT", 1, "Northwest Territories" },
                    { 8, "NU", 1, "Nunavut" },
                    { 9, "ON", 1, "Ontario" },
                    { 10, "PE", 1, "Prince Edward Island" },
                    { 11, "QC", 1, "Quebec" },
                    { 12, "SK", 1, "Saskatchewan" },
                    { 13, "YT", 1, "Yukon" },
                    { 101, "AL", 2, "Alabama" },
                    { 102, "AK", 2, "Alaska" },
                    { 103, "AZ", 2, "Arizona" },
                    { 104, "AR", 2, "Arkansas" },
                    { 105, "CA", 2, "California" },
                    { 106, "CO", 2, "Colorado" },
                    { 107, "CT", 2, "Connecticut" },
                    { 108, "DE", 2, "Delaware" },
                    { 109, "FL", 2, "Florida" },
                    { 110, "GA", 2, "Georgia" },
                    { 111, "HI", 2, "Hawaii" },
                    { 112, "ID", 2, "Idaho" },
                    { 113, "IL", 2, "Illinois" },
                    { 114, "IN", 2, "Indiana" },
                    { 115, "IA", 2, "Iowa" },
                    { 116, "KS", 2, "Kansas" },
                    { 117, "KY", 2, "Kentucky" },
                    { 118, "LA", 2, "Louisiana" },
                    { 119, "ME", 2, "Maine" },
                    { 120, "MD", 2, "Maryland" },
                    { 121, "MA", 2, "Massachusetts" },
                    { 122, "MI", 2, "Michigan" },
                    { 123, "MN", 2, "Minnesota" },
                    { 124, "MS", 2, "Mississippi" },
                    { 125, "MO", 2, "Missouri" },
                    { 126, "MT", 2, "Montana" },
                    { 127, "NE", 2, "Nebraska" },
                    { 128, "NV", 2, "Nevada" },
                    { 129, "NH", 2, "New Hampshire" },
                    { 130, "NJ", 2, "New Jersey" },
                    { 131, "NM", 2, "New Mexico" },
                    { 132, "NY", 2, "New York" },
                    { 133, "NC", 2, "North Carolina" },
                    { 134, "ND", 2, "North Dakota" },
                    { 135, "OH", 2, "Ohio" },
                    { 136, "OK", 2, "Oklahoma" },
                    { 137, "OR", 2, "Oregon" },
                    { 138, "PA", 2, "Pennsylvania" },
                    { 139, "RI", 2, "Rhode Island" },
                    { 140, "SC", 2, "South Carolina" },
                    { 141, "SD", 2, "South Dakota" },
                    { 142, "TN", 2, "Tennessee" },
                    { 143, "TX", 2, "Texas" },
                    { 144, "UT", 2, "Utah" },
                    { 145, "VT", 2, "Vermont" },
                    { 146, "VA", 2, "Virginia" },
                    { 147, "WA", 2, "Washington" },
                    { 148, "WV", 2, "West Virginia" },
                    { 149, "WI", 2, "Wisconsin" },
                    { 150, "WY", 2, "Wyoming" },
                    { 151, "DC", 2, "District of Columbia" }
                });

            migrationBuilder.InsertData(
                table: "ClientProjects",
                columns: new[] { "Id", "AwardedAt", "ClientPmId", "CompanyId", "CreatedAt", "EstimatedHour", "Location", "ProjectName", "ProjectNo", "ProjectRate", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 12, 28, 3, 48, 34, 944, DateTimeKind.Utc).AddTicks(8831), 1240, "New York, NY", "Downtown Office", "CL-PRJ-001", 150.00m, new DateTime(2025, 12, 28, 3, 48, 34, 944, DateTimeKind.Utc).AddTicks(8832) },
                    { 2, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2025, 12, 28, 3, 48, 34, 944, DateTimeKind.Utc).AddTicks(8835), 3000, "Chicago, IL", "Lakeside Residential Complex", "CL-PRJ-002", 120.00m, new DateTime(2025, 12, 28, 3, 48, 34, 944, DateTimeKind.Utc).AddTicks(8835) }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AccountId", "CompanyId", "DateOfBirth", "DeactivatedAt", "FirstName", "IsActive", "JobId", "LastName", "RatePerHour", "ReactivatedAt" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee", true, 1, "Grannon", 65.00m, null },
                    { 2, null, 1, new DateTime(1982, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", true, 6, "Harvey", 40.00m, null }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "CreatedAt", "IsPrimary", "PersonId", "PostalCode", "StateId", "StreetName", "StreetNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Parksville", new DateTime(2025, 12, 28, 3, 48, 34, 940, DateTimeKind.Utc).AddTicks(5763), true, 1, "12345", 2, "Main St", "123", new DateTime(2025, 12, 28, 3, 48, 34, 940, DateTimeKind.Utc).AddTicks(5764) },
                    { 2, "Nanaimo", new DateTime(2025, 12, 28, 3, 48, 34, 940, DateTimeKind.Utc).AddTicks(5767), false, 2, "67890", 2, "Elm St", "456", new DateTime(2025, 12, 28, 3, 48, 34, 940, DateTimeKind.Utc).AddTicks(5767) }
                });

            migrationBuilder.InsertData(
                table: "AssignedRoles",
                columns: new[] { "Id", "AssignedAt", "AssigneeId", "AssignorId", "IsPrimary", "RoleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 28, 3, 48, 34, 944, DateTimeKind.Utc).AddTicks(4103), 1, 1, true, 1 },
                    { 2, new DateTime(2025, 12, 28, 3, 48, 34, 944, DateTimeKind.Utc).AddTicks(4105), 2, 1, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "EmailAddresses",
                columns: new[] { "Id", "CreatedAt", "Email", "IsPrimary", "PersonId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 27, 19, 48, 34, 945, DateTimeKind.Local).AddTicks(7645), "lgrannon@qualitydraftingco.com", true, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 12, 27, 19, 48, 34, 945, DateTimeKind.Local).AddTicks(7682), "mharvey@qualitydraftingco.com", true, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "CountryId", "CreatedAt", "IsPrimary", "PersonId", "PhoneNumber", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 12, 28, 3, 48, 34, 948, DateTimeKind.Utc).AddTicks(581), true, 1, "1234567890", 1, new DateTime(2025, 12, 28, 3, 48, 34, 948, DateTimeKind.Utc).AddTicks(582) },
                    { 2, 1, new DateTime(2025, 12, 28, 3, 48, 34, 948, DateTimeKind.Utc).AddTicks(583), true, 2, "0987654321", 2, new DateTime(2025, 12, 28, 3, 48, 34, 948, DateTimeKind.Utc).AddTicks(584) }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ActualHours", "ClientProjectId", "CreatedAt", "EndDate", "InternalProjectNo", "IsClosed", "ProjectManagerId", "StartDate", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 0, 1, new DateTime(2025, 12, 28, 3, 48, 34, 948, DateTimeKind.Utc).AddTicks(8665), new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internal-PRJ-001", false, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 28, 3, 48, 34, 948, DateTimeKind.Utc).AddTicks(8666) },
                    { 2, 0, 2, new DateTime(2025, 12, 28, 3, 48, 34, 948, DateTimeKind.Utc).AddTicks(8669), new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internal-PRJ-002", false, 2, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 28, 3, 48, 34, 948, DateTimeKind.Utc).AddTicks(8669) }
                });

            migrationBuilder.InsertData(
                table: "Phases",
                columns: new[] { "Id", "Comment", "CreatedAt", "PhaseName", "PhaseNumber", "ProjectId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "All parts", new DateTime(2025, 12, 28, 3, 48, 34, 947, DateTimeKind.Utc).AddTicks(3172), "Office Building", 1, 1, new DateTime(2025, 12, 28, 3, 48, 34, 947, DateTimeKind.Utc).AddTicks(3172) },
                    { 2, "Roof Frames", new DateTime(2025, 12, 28, 3, 48, 34, 947, DateTimeKind.Utc).AddTicks(3175), "Office RTUs", 2, 1, new DateTime(2025, 12, 28, 3, 48, 34, 947, DateTimeKind.Utc).AddTicks(3176) }
                });

            migrationBuilder.InsertData(
                table: "ProjectAreas",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 1, "Main Office", 1 },
                    { 2, "Shop Office", 1 },
                    { 3, "Rec. Pool", 2 }
                });

            migrationBuilder.InsertData(
                table: "TaskDetails",
                columns: new[] { "Id", "AreaId", "CreatedAt", "Description", "DueDate", "EstimatedHours", "PhaseId", "PriorityId", "ProjectId", "TaskNameId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 12, 28, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(5924), "Initial task detail description", new DateTime(2026, 1, 7, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(5922), 40, 1, 1, 1, 1, "Column to beam", new DateTime(2025, 12, 28, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(5925) },
                    { 2, null, new DateTime(2025, 12, 28, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(5930), "Second task detail description", new DateTime(2026, 1, 12, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(5929), 20, 2, 2, 1, 2, "Column layout", new DateTime(2025, 12, 28, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(5930) }
                });

            migrationBuilder.InsertData(
                table: "TaskAssignments",
                columns: new[] { "Id", "CreatedAt", "TaskAssigneeId", "TaskAssignorId", "TaskDetailId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 28, 3, 48, 34, 952, DateTimeKind.Utc).AddTicks(5005), 2, 1, 1, new DateTime(2025, 12, 28, 3, 48, 34, 952, DateTimeKind.Utc).AddTicks(5005) },
                    { 2, new DateTime(2025, 12, 28, 3, 48, 34, 952, DateTimeKind.Utc).AddTicks(5008), 2, 1, 2, new DateTime(2025, 12, 28, 3, 48, 34, 952, DateTimeKind.Utc).AddTicks(5008) }
                });

            migrationBuilder.InsertData(
                table: "TaskLogs",
                columns: new[] { "Id", "CreatedAt", "TaskDetailId", "TaskStateId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 28, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(8569), 1, 1, new DateTime(2025, 12, 28, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(8569) },
                    { 2, new DateTime(2025, 12, 28, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(8572), 2, 1, new DateTime(2025, 12, 28, 3, 48, 34, 953, DateTimeKind.Utc).AddTicks(8572) }
                });

            migrationBuilder.InsertData(
                table: "TaskProgresses",
                columns: new[] { "Id", "CreatedAt", "Date", "SpentHours", "TaskAssignmentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 28, 3, 48, 34, 954, DateTimeKind.Utc).AddTicks(1355), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 1, new DateTime(2025, 12, 28, 3, 48, 34, 954, DateTimeKind.Utc).AddTicks(1356) },
                    { 2, new DateTime(2025, 12, 28, 3, 48, 34, 954, DateTimeKind.Utc).AddTicks(1359), new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5, 2, new DateTime(2025, 12, 28, 3, 48, 34, 954, DateTimeKind.Utc).AddTicks(1359) },
                    { 3, new DateTime(2025, 12, 28, 3, 48, 34, 954, DateTimeKind.Utc).AddTicks(1361), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 1, new DateTime(2025, 12, 28, 3, 48, 34, 954, DateTimeKind.Utc).AddTicks(1362) },
                    { 4, new DateTime(2025, 12, 28, 3, 48, 34, 954, DateTimeKind.Utc).AddTicks(1364), new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 2, new DateTime(2025, 12, 28, 3, 48, 34, 954, DateTimeKind.Utc).AddTicks(1364) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountClaims_PersonId",
                table: "AccountClaims",
                column: "PersonId",
                unique: true,
                filter: "[IsActive] = 1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountClaims_TokenHash",
                table: "AccountClaims",
                column: "TokenHash",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountClaims_UsedByAccountId",
                table: "AccountClaims",
                column: "UsedByAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonId",
                table: "Addresses",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StateId",
                table: "Addresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoles_Name",
                table: "AppRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRoles_AssigneeId",
                table: "AssignedRoles",
                column: "AssigneeId",
                unique: true,
                filter: "[IsPrimary] = 1");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRoles_AssigneeId_RoleId",
                table: "AssignedRoles",
                columns: new[] { "AssigneeId", "RoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRoles_AssignorId",
                table: "AssignedRoles",
                column: "AssignorId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRoles_RoleId",
                table: "AssignedRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProjects_ClientPmId",
                table: "ClientProjects",
                column: "ClientPmId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProjects_CompanyId_ProjectNo",
                table: "ClientProjects",
                columns: new[] { "CompanyId", "ProjectNo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientProjects_ProjectName",
                table: "ClientProjects",
                column: "ProjectName",
                unique: true,
                filter: "[ProjectName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Name",
                table: "Companies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_Type",
                table: "CompanyTypes",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_IsoCode",
                table: "Countries",
                column: "IsoCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddresses_Email",
                table: "EmailAddresses",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddresses_PersonId",
                table: "EmailAddresses",
                column: "PersonId",
                unique: true,
                filter: "[IsPrimary] = 1");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddresses_PersonId_Email",
                table: "EmailAddresses",
                columns: new[] { "PersonId", "Email" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_SinHash",
                table: "EmployeeProfiles",
                column: "SinHash",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_Title",
                table: "Jobs",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AccountId",
                table: "Persons",
                column: "AccountId",
                unique: true,
                filter: "[AccountId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CompanyId",
                table: "Persons",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_JobId",
                table: "Persons",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Phases_PhaseNumber_ProjectId",
                table: "Phases",
                columns: new[] { "PhaseNumber", "ProjectId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phases_ProjectId",
                table: "Phases",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CountryId",
                table: "Phones",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_PersonId",
                table: "Phones",
                column: "PersonId",
                unique: true,
                filter: "[IsPrimary] = 1");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_TypeId",
                table: "Phones",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneTypes_Type",
                table: "PhoneTypes",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Priorities_Name",
                table: "Priorities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAreas_Name_ProjectId",
                table: "ProjectAreas",
                columns: new[] { "Name", "ProjectId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAreas_ProjectId",
                table: "ProjectAreas",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientProjectId",
                table: "Projects",
                column: "ClientProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_InternalProjectNo",
                table: "Projects",
                column: "InternalProjectNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectManagerId",
                table: "Projects",
                column: "ProjectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId_Code",
                table: "States",
                columns: new[] { "CountryId", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId_Name",
                table: "States",
                columns: new[] { "CountryId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssignments_TaskAssigneeId",
                table: "TaskAssignments",
                column: "TaskAssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssignments_TaskAssignorId",
                table: "TaskAssignments",
                column: "TaskAssignorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssignments_TaskDetailId_TaskAssigneeId",
                table: "TaskAssignments",
                columns: new[] { "TaskDetailId", "TaskAssigneeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskComments_TaskProgressId",
                table: "TaskComments",
                column: "TaskProgressId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetails_AreaId",
                table: "TaskDetails",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetails_PhaseId",
                table: "TaskDetails",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetails_PriorityId",
                table: "TaskDetails",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetails_ProjectId",
                table: "TaskDetails",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetails_TaskNameId_Title_ProjectId_PhaseId",
                table: "TaskDetails",
                columns: new[] { "TaskNameId", "Title", "ProjectId", "PhaseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskLogs_TaskDetailId",
                table: "TaskLogs",
                column: "TaskDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskLogs_TaskStateId",
                table: "TaskLogs",
                column: "TaskStateId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskNames_Name",
                table: "TaskNames",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskProgresses_TaskAssignmentId",
                table: "TaskProgresses",
                column: "TaskAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStates_Name",
                table: "TaskStates",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountClaims");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AssignedRoles");

            migrationBuilder.DropTable(
                name: "EmailAddresses");

            migrationBuilder.DropTable(
                name: "EmployeeProfiles");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "TaskComments");

            migrationBuilder.DropTable(
                name: "TaskLogs");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "PhoneTypes");

            migrationBuilder.DropTable(
                name: "TaskProgresses");

            migrationBuilder.DropTable(
                name: "TaskStates");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "TaskAssignments");

            migrationBuilder.DropTable(
                name: "TaskDetails");

            migrationBuilder.DropTable(
                name: "Phases");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "ProjectAreas");

            migrationBuilder.DropTable(
                name: "TaskNames");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ClientProjects");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
