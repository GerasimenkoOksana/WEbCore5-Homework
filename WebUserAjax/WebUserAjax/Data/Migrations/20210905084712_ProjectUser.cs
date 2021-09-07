using Microsoft.EntityFrameworkCore.Migrations;

namespace WebUserAjax.Data.Migrations
{
    public partial class ProjectUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstNamne",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastNamne",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstNamne",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastNamne",
                table: "AspNetUsers");
        }
    }
}
