using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniClinicaApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddPrecioConsultaToCita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecioConsulta",
                table: "Citas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioConsulta",
                table: "Citas");
        }
    }
}
