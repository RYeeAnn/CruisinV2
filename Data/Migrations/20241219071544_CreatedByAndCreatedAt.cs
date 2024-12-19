using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruisinV2.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatedByAndCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostedBy",
                table: "Maintenance",
                newName: "CreatedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Maintenance",
                newName: "PostedBy");
        }
    }
}
