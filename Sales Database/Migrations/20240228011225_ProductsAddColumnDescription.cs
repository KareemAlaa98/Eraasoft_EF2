﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales_Database.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAddColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "No Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");
        }
    }
}
