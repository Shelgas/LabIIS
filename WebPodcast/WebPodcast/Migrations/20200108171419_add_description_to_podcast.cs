using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPodcast.Migrations
{
    public partial class add_description_to_podcast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Podcasts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Podcasts");
        }
    }
}
