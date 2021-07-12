using Microsoft.EntityFrameworkCore.Migrations;

namespace PrsWebApi.Migrations
{
    public partial class addedprductclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorID = table.Column<int>(maxLength: 3, nullable: false),
                    PartNumber = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Unit = table.Column<int>(maxLength: 6, nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
