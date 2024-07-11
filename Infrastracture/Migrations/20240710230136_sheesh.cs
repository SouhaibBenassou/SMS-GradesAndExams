using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class sheesh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_SessionsExams_SessionsExamId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Supervisors_SupervisorId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionsExams_Exams_ExamId",
                table: "SessionsExams");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionsExams_Rooms_IdRoom",
                table: "SessionsExams");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_Exams_ExamId",
                table: "Supervisors");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_Rooms_RoomId",
                table: "Supervisors");

            migrationBuilder.DropIndex(
                name: "IX_Supervisors_ExamId",
                table: "Supervisors");

            migrationBuilder.DropIndex(
                name: "IX_Supervisors_RoomId",
                table: "Supervisors");

            migrationBuilder.DropIndex(
                name: "IX_SessionsExams_ExamId",
                table: "SessionsExams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SessionsExamId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SupervisorId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "SessionsExams");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SessionsExams");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "Exams");

            migrationBuilder.AddColumn<Guid>(
                name: "IdSupervisor",
                table: "SessionsExams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SessionsExams_IdSupervisor",
                table: "SessionsExams",
                column: "IdSupervisor");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SessionsExamId",
                table: "Exams",
                column: "SessionsExamId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_SessionsExams_SessionsExamId",
                table: "Exams",
                column: "SessionsExamId",
                principalTable: "SessionsExams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionsExams_Rooms_IdRoom",
                table: "SessionsExams",
                column: "IdRoom",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionsExams_Supervisors_IdSupervisor",
                table: "SessionsExams",
                column: "IdSupervisor",
                principalTable: "Supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_SessionsExams_SessionsExamId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionsExams_Rooms_IdRoom",
                table: "SessionsExams");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionsExams_Supervisors_IdSupervisor",
                table: "SessionsExams");

            migrationBuilder.DropIndex(
                name: "IX_SessionsExams_IdSupervisor",
                table: "SessionsExams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SessionsExamId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IdSupervisor",
                table: "SessionsExams");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rooms");

            migrationBuilder.AddColumn<Guid>(
                name: "ExamId",
                table: "Supervisors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Supervisors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExamId",
                table: "SessionsExams",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "SessionsExams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "SupervisorId",
                table: "Exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Supervisors_ExamId",
                table: "Supervisors",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisors_RoomId",
                table: "Supervisors",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionsExams_ExamId",
                table: "SessionsExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SessionsExamId",
                table: "Exams",
                column: "SessionsExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SupervisorId",
                table: "Exams",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_SessionsExams_SessionsExamId",
                table: "Exams",
                column: "SessionsExamId",
                principalTable: "SessionsExams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Supervisors_SupervisorId",
                table: "Exams",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionsExams_Exams_ExamId",
                table: "SessionsExams",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionsExams_Rooms_IdRoom",
                table: "SessionsExams",
                column: "IdRoom",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_Exams_ExamId",
                table: "Supervisors",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_Rooms_RoomId",
                table: "Supervisors",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
