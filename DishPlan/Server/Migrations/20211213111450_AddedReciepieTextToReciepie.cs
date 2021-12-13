using Microsoft.EntityFrameworkCore.Migrations;

namespace DishPlan.Server.Migrations
{
    public partial class AddedReciepieTextToReciepie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReciepieText",
                table: "Reciepies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReciepieText",
                table: "Reciepies");
        }
    }
}
