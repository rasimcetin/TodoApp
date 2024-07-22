using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoData.Migrations
{
    /// <inheritdoc />
    public partial class TodoPropertyChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Todos",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Todos",
                newName: "Description");
        }
    }
}
