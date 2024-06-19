using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_College.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    adminEmail = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    password = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    role = table.Column<int>(type: "int", nullable: true),
                    AdminImg = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    userEmail = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    message = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    departmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    departmentDesc = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.departmentID);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    facilityName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: false),
                    facilityDesc = table.Column<string>(type: "text", nullable: false),
                    facilityImg = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    studentEmail = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    password = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    role = table.Column<int>(type: "int", nullable: true),
                    StdImg = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentID);
                });

            migrationBuilder.CreateTable(
                name: "faculties",
                columns: table => new
                {
                    facultyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    facultyName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: false),
                    facultyEmail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    facultyPassword = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: false),
                    facultyDepartment = table.Column<int>(type: "int", nullable: false),
                    facultyImg = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    gender = table.Column<int>(type: "int", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculties", x => x.facultyID);
                    table.ForeignKey(
                        name: "FK__faculties__facul__3F466844",
                        column: x => x.facultyDepartment,
                        principalTable: "Department",
                        principalColumn: "departmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    courseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: false),
                    courseDesc = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: false),
                    courseImg = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    courseDuration = table.Column<int>(type: "int", nullable: false),
                    facultyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.courseID);
                    table.ForeignKey(
                        name: "FK__Courses__faculty__4222D4EF",
                        column: x => x.facultyID,
                        principalTable: "faculties",
                        principalColumn: "facultyID");
                });

            migrationBuilder.CreateTable(
                name: "StudentCourseRegistration",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentID = table.Column<int>(type: "int", nullable: true),
                    studentName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    fatherName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    motherName = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    residentalAddress = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    permanentAddress = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    addmissionFor = table.Column<int>(type: "int", nullable: true),
                    trackingID = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseRegistration", x => x.id);
                    table.ForeignKey(
                        name: "FK__StudentCo__addmi__47DBAE45",
                        column: x => x.addmissionFor,
                        principalTable: "Courses",
                        principalColumn: "courseID");
                    table.ForeignKey(
                        name: "FK__StudentCo__stude__46E78A0C",
                        column: x => x.studentID,
                        principalTable: "Students",
                        principalColumn: "studentID");
                });

            migrationBuilder.CreateTable(
                name: "PreviousExam",
                columns: table => new
                {
                    examID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentDataID = table.Column<int>(type: "int", nullable: true),
                    instituteName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    enrollmentNumber = table.Column<int>(type: "int", nullable: true),
                    center = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    stream = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    field = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    marks = table.Column<int>(type: "int", nullable: true),
                    outOf = table.Column<int>(type: "int", nullable: true),
                    classObtained = table.Column<int>(type: "int", nullable: true),
                    sports = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Previous__A56D123FDE5C2BE6", x => x.examID);
                    table.ForeignKey(
                        name: "FK__PreviousE__stude__4AB81AF0",
                        column: x => x.studentDataID,
                        principalTable: "StudentCourseRegistration",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_facultyID",
                table: "Courses",
                column: "facultyID");

            migrationBuilder.CreateIndex(
                name: "IX_faculties_facultyDepartment",
                table: "faculties",
                column: "facultyDepartment");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousExam_studentDataID",
                table: "PreviousExam",
                column: "studentDataID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseRegistration_addmissionFor",
                table: "StudentCourseRegistration",
                column: "addmissionFor");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseRegistration_studentID",
                table: "StudentCourseRegistration",
                column: "studentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "PreviousExam");

            migrationBuilder.DropTable(
                name: "StudentCourseRegistration");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "faculties");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
