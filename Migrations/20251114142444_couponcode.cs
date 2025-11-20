using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class couponcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CouponCode",
                table: "CouPons");

            migrationBuilder.AddColumn<string>(
                name: "CouponCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CouponCode",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "CouponCode",
                table: "CouPons",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
