using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechBoard.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Thread",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thread", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thread_Subject_SubjectRefId",
                        column: x => x.SubjectRefId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThreadRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Thread_ThreadRefId",
                        column: x => x.ThreadRefId,
                        principalTable: "Thread",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Hardware" },
                    { 2, "Software" },
                    { 3, "Games" }
                });

            migrationBuilder.InsertData(
                table: "Thread",
                columns: new[] { "Id", "Heading", "SubjectRefId" },
                values: new object[,]
                {
                    { 1, "GPU", 1 },
                    { 2, "OS", 2 },
                    { 3, "WorldOfWarcraft", 3 }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "TextBody", "ThreadRefId", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, "Nvidia blabalbla", 1, "Nvidia", "GPUuser" },
                    { 2, "Windows blabalbla", 2, "Windows", "OSuser" },
                    { 3, "Shaman blabalbla", 3, "Shaman", "WOWuser" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_ThreadRefId",
                table: "Post",
                column: "ThreadRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Thread_SubjectRefId",
                table: "Thread",
                column: "SubjectRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Thread");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
