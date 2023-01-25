using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgricultureWebApi.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgricalturalTypes",
                columns: table => new
                {
                    AgricalturalTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgricalturalTypes", x => x.AgricalturalTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgricalturalTypeId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.DiseaseId);
                    table.ForeignKey(
                        name: "FK_Diseases_AgricalturalTypes_AgricalturalTypeId",
                        column: x => x.AgricalturalTypeId,
                        principalTable: "AgricalturalTypes",
                        principalColumn: "AgricalturalTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_AgricalturalTypeId",
                table: "Diseases",
                column: "AgricalturalTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "AgricalturalTypes");
        }
    }
}
