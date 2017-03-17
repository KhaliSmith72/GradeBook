using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GradeBook.Migrations
{
    public partial class fluids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Assignment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_ClassID",
                table: "Assignment",
                column: "ClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Class_ClassID",
                table: "Assignment",
                column: "ClassID",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Class_ClassID",
                table: "Assignment");

            migrationBuilder.DropIndex(
                name: "IX_Assignment_ClassID",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Assignment");
        }
    }
}
