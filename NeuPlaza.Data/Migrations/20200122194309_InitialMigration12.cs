using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NeuPlaza.Data.Migrations
{
    public partial class InitialMigration12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Schema_NeuPlaza");

            migrationBuilder.CreateTable(
                name: "Tags",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    UserEmail = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    UserDetail = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerContent = table.Column<string>(nullable: false),
                    AcceptanceStatus = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTitle = table.Column<string>(nullable: false),
                    QuestionContent = table.Column<string>(nullable: false),
                    AcceptanceStatus = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentContent = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    QuestionId = table.Column<long>(nullable: false),
                    AnswerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    QuestionId = table.Column<long>(nullable: false),
                    AnswerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Points_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Points_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Points_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TagDetails",
                schema: "Schema_NeuPlaza",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagId = table.Column<long>(nullable: false),
                    QuestionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagDetails_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TagDetails_Tags_TagId",
                        column: x => x.TagId,
                        principalSchema: "Schema_NeuPlaza",
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserId",
                schema: "Schema_NeuPlaza",
                table: "Answers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnswerId",
                schema: "Schema_NeuPlaza",
                table: "Comments",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_QuestionId",
                schema: "Schema_NeuPlaza",
                table: "Comments",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                schema: "Schema_NeuPlaza",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Points_AnswerId",
                schema: "Schema_NeuPlaza",
                table: "Points",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Points_QuestionId",
                schema: "Schema_NeuPlaza",
                table: "Points",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Points_UserId",
                schema: "Schema_NeuPlaza",
                table: "Points",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UserId",
                schema: "Schema_NeuPlaza",
                table: "Questions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TagDetails_QuestionId",
                schema: "Schema_NeuPlaza",
                table: "TagDetails",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagDetails_TagId",
                schema: "Schema_NeuPlaza",
                table: "TagDetails",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserEmail",
                schema: "Schema_NeuPlaza",
                table: "Users",
                column: "UserEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                schema: "Schema_NeuPlaza",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Points",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "TagDetails",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Answers",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Questions",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Tags",
                schema: "Schema_NeuPlaza");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Schema_NeuPlaza");
        }
    }
}
