using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace AmbulanceSystem.Migrations
{
    public partial class SecondSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmbulanceCompanyId",
                table: "Service",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "AmbulanceCompanyId",
                table: "IPS",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "AmbulanceCompanyId",
                table: "Ambulance",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Ambulance_AmbulanceCompany_AmbulanceCompanyId",
                table: "Ambulance",
                column: "AmbulanceCompanyId",
                principalTable: "AmbulanceCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IPS_AmbulanceCompany_AmbulanceCompanyId",
                table: "IPS",
                column: "AmbulanceCompanyId",
                principalTable: "AmbulanceCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Service_AmbulanceCompany_AmbulanceCompanyId",
                table: "Service",
                column: "AmbulanceCompanyId",
                principalTable: "AmbulanceCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Ambulance_AmbulanceCompany_AmbulanceCompanyId", table: "Ambulance");
            migrationBuilder.DropForeignKey(name: "FK_IPS_AmbulanceCompany_AmbulanceCompanyId", table: "IPS");
            migrationBuilder.DropForeignKey(name: "FK_Service_AmbulanceCompany_AmbulanceCompanyId", table: "Service");
            migrationBuilder.DropColumn(name: "AmbulanceCompanyId", table: "Service");
            migrationBuilder.DropColumn(name: "AmbulanceCompanyId", table: "IPS");
            migrationBuilder.DropColumn(name: "AmbulanceCompanyId", table: "Ambulance");
        }
    }
}
