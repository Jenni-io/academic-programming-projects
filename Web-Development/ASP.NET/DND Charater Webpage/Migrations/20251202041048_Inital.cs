using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ch4Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ancestors",
                columns: table => new
                {
                    AncestryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestors", x => x.AncestryId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    AncestryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterID);
                    table.ForeignKey(
                        name: "FK_Characters_Ancestors_AncestryId",
                        column: x => x.AncestryId,
                        principalTable: "Ancestors",
                        principalColumn: "AncestryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ancestors",
                columns: new[] { "AncestryId", "Origin" },
                values: new object[,]
                {
                    { 1, "Elf" },
                    { 2, "Dwarf" },
                    { 3, "Halfling" },
                    { 4, "Gnome" },
                    { 5, "Human" },
                    { 6, "Half-elf" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Name" },
                values: new object[,]
                {
                    { 1, "Bard" },
                    { 2, "Cleric" },
                    { 3, "Druid" },
                    { 4, "Fighter" },
                    { 5, "Paladin" },
                    { 6, "Sorcerer" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterID", "AncestryId", "ClassId", "FirstName", "Intelligence", "LastName", "Strength" },
                values: new object[,]
                {
                    { 1, 6, 5, "Markimus", 11, "Maximus", 16 },
                    { 2, 2, 2, "Loismus", 18, "Blaismus", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AncestryId",
                table: "Characters",
                column: "AncestryId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Ancestors");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
