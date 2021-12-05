using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OOP_ASU_5.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentLinks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentLinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Laboriousness = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_ContentLinks_ContentLinkId",
                        column: x => x.ContentLinkId,
                        principalTable: "ContentLinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisciplineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplines_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExercisesBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseBlockType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseBlockSubType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MethodicalInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercisesBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExercisesBlocks_ContentLinks_ContentLinkId",
                        column: x => x.ContentLinkId,
                        principalTable: "ContentLinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExercisesBlocks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DifficultyCoefficient = table.Column<double>(type: "float", nullable: false),
                    ExercisesBlockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_ContentLinks_ContentLinkId",
                        column: x => x.ContentLinkId,
                        principalTable: "ContentLinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercises_ExercisesBlocks_ExercisesBlockId",
                        column: x => x.ExercisesBlockId,
                        principalTable: "ExercisesBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseVariants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DifficultyCoefficient = table.Column<double>(type: "float", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseVariants_ContentLinks_ContentLinkId",
                        column: x => x.ContentLinkId,
                        principalTable: "ContentLinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExerciseVariants_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OptionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeFormat = table.Column<bool>(type: "bit", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_LessonId",
                table: "Disciplines",
                column: "LessonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ContentLinkId",
                table: "Exercises",
                column: "ContentLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExercisesBlockId",
                table: "Exercises",
                column: "ExercisesBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ExercisesBlocks_ContentLinkId",
                table: "ExercisesBlocks",
                column: "ContentLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_ExercisesBlocks_LessonId",
                table: "ExercisesBlocks",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseVariants_ContentLinkId",
                table: "ExerciseVariants",
                column: "ContentLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseVariants_ExerciseId",
                table: "ExerciseVariants",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ContentLinkId",
                table: "Lessons",
                column: "ContentLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_ExerciseId",
                table: "Options",
                column: "ExerciseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "ExerciseVariants");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "ExercisesBlocks");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "ContentLinks");
        }
    }
}
