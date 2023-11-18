using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace profileAPi.Migrations
{
    /// <inheritdoc />
    public partial class sextaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "ProfileData",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "ProfileData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "ProfileData");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "ProfileData");
        }
    }
}
