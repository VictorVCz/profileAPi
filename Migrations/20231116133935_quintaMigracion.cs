using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace profileAPi.Migrations
{
    /// <inheritdoc />
    public partial class quintaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FrameworkData",
                columns: table => new
                {
                    FrameworkName = table.Column<string>(type: "TEXT", nullable: false),
                    FrameworkDate = table.Column<string>(type: "TEXT", nullable: false),
                    IsLearned = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkData", x => x.FrameworkName);
                    table.ForeignKey(
                        name: "FK_FrameworkData_ProfileData_ProfileName",
                        column: x => x.ProfileName,
                        principalTable: "ProfileData",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "HobbyData",
                columns: table => new
                {
                    HobbyName = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyData", x => x.HobbyName);
                    table.ForeignKey(
                        name: "FK_HobbyData_ProfileData_ProfileName",
                        column: x => x.ProfileName,
                        principalTable: "ProfileData",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FrameworkData_ProfileName",
                table: "FrameworkData",
                column: "ProfileName");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyData_ProfileName",
                table: "HobbyData",
                column: "ProfileName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FrameworkData");

            migrationBuilder.DropTable(
                name: "HobbyData");
        }
    }
}
