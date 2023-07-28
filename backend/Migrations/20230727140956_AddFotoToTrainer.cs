using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIsTrainME.Migrations
{
    /// <inheritdoc />
    public partial class AddFotoToTrainer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Trainers",
                newName: "Foto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Trainers",
                newName: "Image");
        }
    }
}
