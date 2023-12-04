using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgricultureWebApi.Migrations
{
    /// <inheritdoc />
    public partial class editAgriculturalDisase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "AgriculturalDiseases",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "AgriculturalDiseases");
        }
    }
}
