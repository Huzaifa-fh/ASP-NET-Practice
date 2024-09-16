using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexEmulation.Migrations
{
    /// <inheritdoc />
    public partial class InititalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseInstructors_Courses_CourseId",
                table: "SectionCourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseInstructors_Sections_SectionId",
                table: "SectionCourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionStudentCourses_Courses_CourseId",
                table: "SectionStudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionStudentCourses_Sections_SectionId",
                table: "SectionStudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_SectionStudentCourses_CourseId",
                table: "SectionStudentCourses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "SectionStudentCourses");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "SectionStudentCourses",
                newName: "SectionCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_SectionStudentCourses_SectionId",
                table: "SectionStudentCourses",
                newName: "IX_SectionStudentCourses_SectionCourseId");

            migrationBuilder.AlterColumn<int>(
                name: "RollNo",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "SectionCourseInstructors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "SectionCourseInstructors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SectionCourseId",
                table: "SectionCourseInstructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SectionCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionCourses_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionCourseInstructors_SectionCourseId",
                table: "SectionCourseInstructors",
                column: "SectionCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCourses_CourseId",
                table: "SectionCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCourses_SectionId",
                table: "SectionCourses",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseInstructors_Courses_CourseId",
                table: "SectionCourseInstructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseInstructors_SectionCourses_SectionCourseId",
                table: "SectionCourseInstructors",
                column: "SectionCourseId",
                principalTable: "SectionCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseInstructors_Sections_SectionId",
                table: "SectionCourseInstructors",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionStudentCourses_SectionCourses_SectionCourseId",
                table: "SectionStudentCourses",
                column: "SectionCourseId",
                principalTable: "SectionCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseInstructors_Courses_CourseId",
                table: "SectionCourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseInstructors_SectionCourses_SectionCourseId",
                table: "SectionCourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionCourseInstructors_Sections_SectionId",
                table: "SectionCourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionStudentCourses_SectionCourses_SectionCourseId",
                table: "SectionStudentCourses");

            migrationBuilder.DropTable(
                name: "SectionCourses");

            migrationBuilder.DropIndex(
                name: "IX_SectionCourseInstructors_SectionCourseId",
                table: "SectionCourseInstructors");

            migrationBuilder.DropColumn(
                name: "SectionCourseId",
                table: "SectionCourseInstructors");

            migrationBuilder.RenameColumn(
                name: "SectionCourseId",
                table: "SectionStudentCourses",
                newName: "SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_SectionStudentCourses_SectionCourseId",
                table: "SectionStudentCourses",
                newName: "IX_SectionStudentCourses_SectionId");

            migrationBuilder.AlterColumn<int>(
                name: "RollNo",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "SectionStudentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "SectionCourseInstructors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "SectionCourseInstructors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SectionStudentCourses_CourseId",
                table: "SectionStudentCourses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseInstructors_Courses_CourseId",
                table: "SectionCourseInstructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionCourseInstructors_Sections_SectionId",
                table: "SectionCourseInstructors",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionStudentCourses_Courses_CourseId",
                table: "SectionStudentCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionStudentCourses_Sections_SectionId",
                table: "SectionStudentCourses",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
