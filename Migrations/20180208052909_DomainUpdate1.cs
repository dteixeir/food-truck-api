using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.Migrations
{
    public partial class DomainUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateUserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "ScheduleItem",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateUserId",
                table: "ScheduleItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "MenuItem",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateUserId",
                table: "MenuItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "Menu",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateUserId",
                table: "Menu",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "FoodTrucks",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateUserId",
                table: "FoodTrucks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdateUserId",
                table: "Users",
                column: "UpdateUserId",
                unique: true,
                filter: "[UpdateUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleItem_CreateUserId",
                table: "ScheduleItem",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleItem_UpdateUserId",
                table: "ScheduleItem",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_CreateUserId",
                table: "MenuItem",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_UpdateUserId",
                table: "MenuItem",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_CreateUserId",
                table: "Menu",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_UpdateUserId",
                table: "Menu",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTrucks_CreateUserId",
                table: "FoodTrucks",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTrucks_UpdateUserId",
                table: "FoodTrucks",
                column: "UpdateUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodTrucks_Users_CreateUserId",
                table: "FoodTrucks",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodTrucks_Users_UpdateUserId",
                table: "FoodTrucks",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Users_CreateUserId",
                table: "Menu",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Users_UpdateUserId",
                table: "Menu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Users_CreateUserId",
                table: "MenuItem",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Users_UpdateUserId",
                table: "MenuItem",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleItem_Users_CreateUserId",
                table: "ScheduleItem",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleItem_Users_UpdateUserId",
                table: "ScheduleItem",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UpdateUserId",
                table: "Users",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodTrucks_Users_CreateUserId",
                table: "FoodTrucks");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodTrucks_Users_UpdateUserId",
                table: "FoodTrucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Users_CreateUserId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Users_UpdateUserId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Users_CreateUserId",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Users_UpdateUserId",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleItem_Users_CreateUserId",
                table: "ScheduleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleItem_Users_UpdateUserId",
                table: "ScheduleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UpdateUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UpdateUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleItem_CreateUserId",
                table: "ScheduleItem");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleItem_UpdateUserId",
                table: "ScheduleItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_CreateUserId",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_UpdateUserId",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_Menu_CreateUserId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_UpdateUserId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_FoodTrucks_CreateUserId",
                table: "FoodTrucks");

            migrationBuilder.DropIndex(
                name: "IX_FoodTrucks_UpdateUserId",
                table: "FoodTrucks");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "ScheduleItem");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "ScheduleItem");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "FoodTrucks");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "FoodTrucks");
        }
    }
}
