using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccesLayer.Migrations
{
    public partial class migaddbaskett : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuTableId",
                table: "Baskets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuTableId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
