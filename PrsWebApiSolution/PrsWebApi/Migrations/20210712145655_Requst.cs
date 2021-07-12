using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrsWebApi.Migrations
{
    public partial class Requst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(maxLength: 30, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Justification = table.Column<string>(maxLength: 150, nullable: false),
                    DateNeeded = table.Column<DateTime>(nullable: false),
                    DeliveryMode = table.Column<string>(maxLength: 10, nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    DateSubmitted = table.Column<DateTime>(nullable: false),
                    ReasonForRejection = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
