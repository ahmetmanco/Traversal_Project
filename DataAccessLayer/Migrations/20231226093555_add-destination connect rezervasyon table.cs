using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class adddestinationconnectrezervasyontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Rezervasyonss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyonss_DestinationId",
                table: "Rezervasyonss",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyonss_Destinationss_DestinationId",
                table: "Rezervasyonss",
                column: "DestinationId",
                principalTable: "Destinationss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyonss_Destinationss_DestinationId",
                table: "Rezervasyonss");

            migrationBuilder.DropIndex(
                name: "IX_Rezervasyonss_DestinationId",
                table: "Rezervasyonss");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Rezervasyonss");
        }
    }
}
