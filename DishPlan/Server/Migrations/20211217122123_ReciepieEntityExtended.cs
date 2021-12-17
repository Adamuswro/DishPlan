using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DishPlan.Server.Migrations
{
    public partial class ReciepieEntityExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReciepieText",
                table: "Reciepies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Reciepies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Reciepies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SourceLink",
                table: "Reciepies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Reciepies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Reciepies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Reciepies");

            migrationBuilder.DropColumn(
                name: "SourceLink",
                table: "Reciepies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Reciepies");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Reciepies");

            migrationBuilder.AlterColumn<string>(
                name: "ReciepieText",
                table: "Reciepies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Reciepies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
