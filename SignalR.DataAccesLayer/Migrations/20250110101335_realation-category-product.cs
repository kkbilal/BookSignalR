using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccesLayer.Migrations
{
    public partial class realationcategoryproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestimonialID",
                table: "Testimonials",
                newName: "TestimonialId");

            migrationBuilder.RenameColumn(
                name: "SocialMediaID",
                table: "SocialMedias",
                newName: "SocialMediaId");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "FeatureID",
                table: "Features",
                newName: "FeatureId");

            migrationBuilder.RenameColumn(
                name: "DiscountID",
                table: "Discounts",
                newName: "DiscountId");

            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "Contacts",
                newName: "ContactId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "Bookings",
                newName: "BookingId");

            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "Abouts",
                newName: "AboutId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TestimonialId",
                table: "Testimonials",
                newName: "TestimonialID");

            migrationBuilder.RenameColumn(
                name: "SocialMediaId",
                table: "SocialMedias",
                newName: "SocialMediaID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "FeatureId",
                table: "Features",
                newName: "FeatureID");

            migrationBuilder.RenameColumn(
                name: "DiscountId",
                table: "Discounts",
                newName: "DiscountID");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Contacts",
                newName: "ContactID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Bookings",
                newName: "BookingID");

            migrationBuilder.RenameColumn(
                name: "AboutId",
                table: "Abouts",
                newName: "AboutID");
        }
    }
}
