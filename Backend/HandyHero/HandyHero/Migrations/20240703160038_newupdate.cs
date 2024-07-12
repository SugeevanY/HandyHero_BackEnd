using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandyHero.Migrations
{
    /// <inheritdoc />
    public partial class newupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VerificationCode",
                table: "FieldWorker",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerificationCode",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerificationCode",
                table: "FieldWorker");

            migrationBuilder.DropColumn(
                name: "VerificationCode",
                table: "Customer");
        }
    }
}
