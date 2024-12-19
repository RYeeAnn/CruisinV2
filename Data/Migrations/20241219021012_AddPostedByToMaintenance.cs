using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CruisinV2.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPostedByToMaintenance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Maintenance",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PostedBy",
                table: "Maintenance",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Maintenance");

            migrationBuilder.DropColumn(
                name: "PostedBy",
                table: "Maintenance");
        }
    }
}
