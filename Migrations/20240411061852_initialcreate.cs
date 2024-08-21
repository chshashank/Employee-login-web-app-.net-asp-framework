using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillAssessments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    BasicUnderstanding = table.Column<int>(type: "int", nullable: false),
                    WorkingExperience = table.Column<int>(type: "int", nullable: false),
                    ExtensiveExperience = table.Column<int>(type: "int", nullable: false),
                    SubjectMatterExperience = table.Column<int>(type: "int", nullable: false),
                    Database = table.Column<int>(type: "int", nullable: false),
                    Programming = table.Column<int>(type: "int", nullable: false),
                    Java = table.Column<int>(type: "int", nullable: false),
                    CSharp = table.Column<int>(type: "int", nullable: false),
                    Python = table.Column<int>(type: "int", nullable: false),
                    WebProgramming = table.Column<int>(type: "int", nullable: false),
                    OtherTechnicalSkills = table.Column<int>(type: "int", nullable: false),
                    VerbalCommunication = table.Column<int>(type: "int", nullable: false),
                    WrittenCommunication = table.Column<int>(type: "int", nullable: false),
                    ForeignLanguage = table.Column<int>(type: "int", nullable: false),
                    Teamwork = table.Column<int>(type: "int", nullable: false),
                    ProblemSolving = table.Column<int>(type: "int", nullable: false),
                    DecisionMaking = table.Column<int>(type: "int", nullable: false),
                    Leadership = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillAssessments", x => x.Id);

                });
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportingManager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalITExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BachelorDegree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BachelorSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MastersDegree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MastersSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certifications = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                       name: "FK_Employees_SkillAssessments_EmpId",
                       column: x => x.EmpId,
                        principalTable: "SkillAssessments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "SkillAssessments");
        }
    }
}
