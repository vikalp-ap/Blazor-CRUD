using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 4096, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "This is some example content for post1.", "Post 1" },
                    { 2, "This is some example content for post2.", "Post 2" },
                    { 3, "This is some example content for post3.", "Post 3" },
                    { 4, "This is some example content for post4.", "Post 4" },
                    { 5, "This is some example content for post5.", "Post 5" },
                    { 6, "This is some example content for post6.", "Post 6" },
                    { 7, "This is some example content for post7.", "Post 7" },
                    { 8, "This is some example content for post8.", "Post 8" },
                    { 9, "This is some example content for post9.", "Post 9" },
                    { 10, "This is some example content for post10.", "Post 10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
