using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace animalshelterapi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Breed", "Details", "Name" },
                values: new object[,]
                {
                    { 1, "Mutt Tabby Cat", "Cute, but wild. Tends to bite a lot", "Charlie" },
                    { 2, "Mutt Tabby Cat", "Very sweet, overall good cat.", "Mochi" },
                    { 3, "Mutt Black and White Cat", "Very independent cat. ", "Kenji" },
                    { 4, "All Grey Cat", "Lap cat, always needs affection.", "Sumo" },
                    { 5, "German Shepard", "Medium size dog, can be walked without leash.", "Honda" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
