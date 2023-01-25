using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgricultureWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AgriculturalDisease : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgriculturalProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgricalturalTypeId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgriculturalProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgriculturalProduct_AgricalturalTypes_AgricalturalTypeId",
                        column: x => x.AgricalturalTypeId,
                        principalTable: "AgricalturalTypes",
                        principalColumn: "AgricalturalTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgricalturalDiseases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgcicultureProductId = table.Column<int>(type: "int", nullable: false),
                    AgciculturalProductId = table.Column<int>(type: "int", nullable: true),
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgricalturalDiseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgricalturalDiseases_AgriculturalProduct_AgciculturalProductId",
                        column: x => x.AgciculturalProductId,
                        principalTable: "AgriculturalProduct",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AgricalturalDiseases_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgricalturalDiseases_AgciculturalProductId",
                table: "AgricalturalDiseases",
                column: "AgciculturalProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AgricalturalDiseases_DiseaseId",
                table: "AgricalturalDiseases",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AgriculturalProduct_AgricalturalTypeId",
                table: "AgriculturalProduct",
                column: "AgricalturalTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgricalturalDiseases");

            migrationBuilder.DropTable(
                name: "AgriculturalProduct");
        }
    }
}
