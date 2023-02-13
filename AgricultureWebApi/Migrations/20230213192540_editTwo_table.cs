using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgricultureWebApi.Migrations
{
    /// <inheritdoc />
    public partial class editTwotable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgricalturalDiseases_AgriculturalProduct_AgriculturalProductId",
                table: "AgricalturalDiseases");

            migrationBuilder.DropForeignKey(
                name: "FK_AgricalturalDiseases_Diseases_DiseaseId",
                table: "AgricalturalDiseases");

            migrationBuilder.DropForeignKey(
                name: "FK_AgriculturalProduct_AgricalturalTypes_AgricalturalTypeId",
                table: "AgriculturalProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgricalturalTypes",
                table: "AgricalturalTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgricalturalDiseases",
                table: "AgricalturalDiseases");

            migrationBuilder.RenameTable(
                name: "AgricalturalTypes",
                newName: "AgriculturalTypes");

            migrationBuilder.RenameTable(
                name: "AgricalturalDiseases",
                newName: "AgriculturalDiseases");

            migrationBuilder.RenameIndex(
                name: "IX_AgricalturalDiseases_DiseaseId",
                table: "AgriculturalDiseases",
                newName: "IX_AgriculturalDiseases_DiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_AgricalturalDiseases_AgriculturalProductId",
                table: "AgriculturalDiseases",
                newName: "IX_AgriculturalDiseases_AgriculturalProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgriculturalTypes",
                table: "AgriculturalTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgriculturalDiseases",
                table: "AgriculturalDiseases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgriculturalDiseases_AgriculturalProduct_AgriculturalProductId",
                table: "AgriculturalDiseases",
                column: "AgriculturalProductId",
                principalTable: "AgriculturalProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgriculturalDiseases_Diseases_DiseaseId",
                table: "AgriculturalDiseases",
                column: "DiseaseId",
                principalTable: "Diseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgriculturalProduct_AgriculturalTypes_AgricalturalTypeId",
                table: "AgriculturalProduct",
                column: "AgricalturalTypeId",
                principalTable: "AgriculturalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgriculturalDiseases_AgriculturalProduct_AgriculturalProductId",
                table: "AgriculturalDiseases");

            migrationBuilder.DropForeignKey(
                name: "FK_AgriculturalDiseases_Diseases_DiseaseId",
                table: "AgriculturalDiseases");

            migrationBuilder.DropForeignKey(
                name: "FK_AgriculturalProduct_AgriculturalTypes_AgricalturalTypeId",
                table: "AgriculturalProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgriculturalTypes",
                table: "AgriculturalTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgriculturalDiseases",
                table: "AgriculturalDiseases");

            migrationBuilder.RenameTable(
                name: "AgriculturalTypes",
                newName: "AgricalturalTypes");

            migrationBuilder.RenameTable(
                name: "AgriculturalDiseases",
                newName: "AgricalturalDiseases");

            migrationBuilder.RenameIndex(
                name: "IX_AgriculturalDiseases_DiseaseId",
                table: "AgricalturalDiseases",
                newName: "IX_AgricalturalDiseases_DiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_AgriculturalDiseases_AgriculturalProductId",
                table: "AgricalturalDiseases",
                newName: "IX_AgricalturalDiseases_AgriculturalProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgricalturalTypes",
                table: "AgricalturalTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgricalturalDiseases",
                table: "AgricalturalDiseases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgricalturalDiseases_AgriculturalProduct_AgriculturalProductId",
                table: "AgricalturalDiseases",
                column: "AgriculturalProductId",
                principalTable: "AgriculturalProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgricalturalDiseases_Diseases_DiseaseId",
                table: "AgricalturalDiseases",
                column: "DiseaseId",
                principalTable: "Diseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgriculturalProduct_AgricalturalTypes_AgricalturalTypeId",
                table: "AgriculturalProduct",
                column: "AgricalturalTypeId",
                principalTable: "AgricalturalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
