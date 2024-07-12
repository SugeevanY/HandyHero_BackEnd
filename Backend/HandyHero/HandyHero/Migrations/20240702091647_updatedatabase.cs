using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandyHero.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hire");

            migrationBuilder.AddColumn<bool>(
                name: "isHired",
                table: "FieldWorker",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isHired",
                table: "FieldWorker");

            migrationBuilder.CreateTable(
                name: "Hire",
                columns: table => new
                {
                    HireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldWorker = table.Column<int>(type: "int", nullable: false),
                    HireStatus = table.Column<int>(type: "int", nullable: false),
                    QuatationFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hire", x => x.HireId);
                });
        }
    }
}
