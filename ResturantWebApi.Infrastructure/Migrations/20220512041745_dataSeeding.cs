using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResturantWebApi.Infrastructure.Migrations
{
    public partial class dataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryEntity",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { new Guid("1ebd0eb7-f43d-49ac-9665-241400b082ce"), "Fresh Poutlry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryEntity",
                keyColumn: "Id",
                keyValue: new Guid("1ebd0eb7-f43d-49ac-9665-241400b082ce"));
        }
    }
}
