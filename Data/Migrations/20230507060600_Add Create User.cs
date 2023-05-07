using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokeAPPMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCreateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "Joke",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "Joke");
        }
    }
}
