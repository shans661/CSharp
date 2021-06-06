﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Data.Migrations
{
    public partial class LikeUsersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    SourceUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    LikedUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    SourceUserId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.SourceUserId, x.LikedUserId });
                    table.ForeignKey(
                        name: "FK_Likes_User_SourceUserId",
                        column: x => x.SourceUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_User_SourceUserId1",
                        column: x => x.SourceUserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_SourceUserId1",
                table: "Likes",
                column: "SourceUserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");
        }
    }
}
