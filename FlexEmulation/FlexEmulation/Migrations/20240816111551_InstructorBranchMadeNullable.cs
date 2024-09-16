using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexEmulation.Migrations
{
    /// <inheritdoc />
    public partial class InstructorBranchMadeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Branches_BranchId",
                table: "Instructors");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Instructors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Branches_BranchId",
                table: "Instructors",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Branches_BranchId",
                table: "Instructors");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Branches_BranchId",
                table: "Instructors",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
