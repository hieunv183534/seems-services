using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeemsAdmin.Migrations
{
    /// <inheritdoc />
    public partial class Them_Truong_MST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaSoThue",
                table: "AbpUsers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaSoThue",
                table: "AbpUsers");
        }
    }
}
