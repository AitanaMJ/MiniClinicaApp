using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniClinicaApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class agregarHora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Hora",
                table: "Citas",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Citas");
        }
    }
}
