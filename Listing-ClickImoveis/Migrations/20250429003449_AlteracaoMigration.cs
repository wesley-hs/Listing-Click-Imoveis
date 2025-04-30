using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Listing_ClickImoveis.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Midia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Midia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Midia_Listing_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Midia_ListingId",
                table: "Midia",
                column: "ListingId");
        }
    }
}
