using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XP.Formula1.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Car = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Wins = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Points = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Nationality = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver");
        }
    }
}
