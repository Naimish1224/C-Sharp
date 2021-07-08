using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreDDFirst.Migrations
{
    public partial class Addedstatetocustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");
        }
    }
}
