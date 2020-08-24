﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Activity001.Migrations
{
    public partial class EncryptionMigration_Step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDateBackup",
                schema: "HumanResources",
                table: "Employee",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GenderBackup",
                schema: "HumanResources",
                table: "Employee",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDateBackup",
                schema: "HumanResources",
                table: "Employee",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "JobTitleBackup",
                schema: "HumanResources",
                table: "Employee",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatusBackup",
                schema: "HumanResources",
                table: "Employee",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalIDNumberBackup",
                schema: "HumanResources",
                table: "Employee",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDateBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GenderBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HireDateBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobTitleBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MaritalStatusBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "NationalIDNumberBackup",
                schema: "HumanResources",
                table: "Employee");
        }
    }
}
