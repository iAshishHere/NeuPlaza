using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NeuPlaza.Data.Migrations
{
    public partial class FirstRealMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Schema_NeuPlaza");

            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentContent = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Points",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Upvote = table.Column<bool>(nullable: false, defaultValue: false),
                    Downvote = table.Column<bool>(nullable: false, defaultValue: false),
                    AcceptedAnswer = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagDetails",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    AnswerContent = table.Column<string>(nullable: false),
                    AcceptanceStatus = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Comments_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answers_Points_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Points",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    QuestionTitle = table.Column<string>(nullable: false),
                    QuestionContent = table.Column<string>(nullable: false),
                    AcceptanceStatus = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Comments_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Points_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Points",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_TagDetails_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "TagDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_TagDetails_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "TagDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserDetail = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Answers_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Comments_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Points_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Points",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Questions_Id",
                        column: x => x.Id,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TagName",
                schema: "Schema_NeuPlaza",
                table: "Tags",
                column: "TagName",
                unique: true,
                filter: "[TagName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FirstName",
                schema: "Schema_NeuPlaza",
                table: "Users",
                column: "FirstName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserEmail",
                schema: "Schema_NeuPlaza",
                table: "Users",
                column: "UserEmail",
                unique: true,
                filter: "[UserEmail] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Answers",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Questions",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Comments",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Points",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "TagDetails",
                schema: "Schema_NeuPlaza");
        }
    }
}
