using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BSA_2018_Homework_4.Migrations
{
    public partial class TicktUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Flight_FlightNumFlightId",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "FlightNumFlightId",
                table: "Ticket",
                newName: "FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_FlightNumFlightId",
                table: "Ticket",
                newName: "IX_Ticket_FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Flight_FlightId",
                table: "Ticket",
                column: "FlightId",
                principalTable: "Flight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Flight_FlightId",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "Ticket",
                newName: "FlightNumFlightId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket",
                newName: "IX_Ticket_FlightNumFlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Flight_FlightNumFlightId",
                table: "Ticket",
                column: "FlightNumFlightId",
                principalTable: "Flight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
