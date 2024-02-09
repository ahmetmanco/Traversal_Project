using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class destination_guide : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuideId",
                table: "Destinationss",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinationss_GuideId",
                table: "Destinationss",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinationss_Guidess_GuideId",
                table: "Destinationss",
                column: "GuideId",
                principalTable: "Guidess",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinationss_Guidess_GuideId",
                table: "Destinationss");

            migrationBuilder.DropIndex(
                name: "IX_Destinationss_GuideId",
                table: "Destinationss");

            migrationBuilder.DropColumn(
                name: "GuideId",
                table: "Destinationss");
        }
    }
}
