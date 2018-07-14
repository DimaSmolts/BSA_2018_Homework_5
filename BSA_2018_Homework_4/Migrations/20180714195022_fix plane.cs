using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BSA_2018_Homework_4.Migrations
{
    public partial class fixplane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaneType_PLane_PlaneId",
                table: "PlaneType");

            migrationBuilder.DropIndex(
                name: "IX_PlaneType_PlaneId",
                table: "PlaneType");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "PlaneType");

            migrationBuilder.AddColumn<int>(
                name: "PlaneTypeId",
                table: "PLane",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PLane_PlaneTypeId",
                table: "PLane",
                column: "PlaneTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PLane_PlaneType_PlaneTypeId",
                table: "PLane",
                column: "PlaneTypeId",
                principalTable: "PlaneType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PLane_PlaneType_PlaneTypeId",
                table: "PLane");

            migrationBuilder.DropIndex(
                name: "IX_PLane_PlaneTypeId",
                table: "PLane");

            migrationBuilder.DropColumn(
                name: "PlaneTypeId",
                table: "PLane");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "PlaneType",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaneType_PlaneId",
                table: "PlaneType",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaneType_PLane_PlaneId",
                table: "PlaneType",
                column: "PlaneId",
                principalTable: "PLane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
