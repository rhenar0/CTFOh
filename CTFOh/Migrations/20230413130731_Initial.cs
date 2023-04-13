using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFOh.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CTFDetailsChalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Points = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Desc = table.Column<string>(type: "TEXT", nullable: false),
                    Img = table.Column<string>(type: "TEXT", nullable: false),
                    Files = table.Column<string>(type: "TEXT", nullable: false),
                    Links = table.Column<string>(type: "TEXT", nullable: false),
                    Actif = table.Column<int>(type: "INTEGER", nullable: false),
                    LinkedCTF = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTFDetailsChalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTFList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Dstart = table.Column<string>(type: "TEXT", nullable: false),
                    Dend = table.Column<string>(type: "TEXT", nullable: false),
                    Select = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTFList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTFListChalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Actif = table.Column<int>(type: "INTEGER", nullable: false),
                    Chall = table.Column<string>(type: "TEXT", nullable: false),
                    Order = table.Column<string>(type: "TEXT", nullable: false),
                    StrictOrder = table.Column<int>(type: "INTEGER", nullable: false),
                    LinkedCTF = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTFListChalls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTFTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ChkPassword = table.Column<string>(type: "TEXT", nullable: false),
                    NiceChalls = table.Column<string>(type: "TEXT", nullable: false),
                    LinkedCTF = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTFTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTFUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pseudo = table.Column<string>(type: "TEXT", nullable: false),
                    ChkPassword = table.Column<string>(type: "TEXT", nullable: false),
                    Team = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<long>(type: "INTEGER", nullable: false),
                    AssignedChalls = table.Column<string>(type: "TEXT", nullable: false),
                    LinkedCTF = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTFUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CTFDetailsChalls",
                columns: new[] { "Id", "Actif", "Desc", "Files", "Img", "LinkedCTF", "Links", "Name", "Points" },
                values: new object[,]
                {
                    { 1, 1, "Je Bouh", "{\"https://boubouh.txt/text.png\"}", "{\"null\"}", 1, "{\"null\"}", "Bouh", 100L },
                    { 2, 1, "Je Bouh", "{\"https://boubouh.txt/text.png\"}", "{\"https://boubouh.txt/text.png\"}", 1, "{\"null\"}", "Bouhda", 240L },
                    { 3, 1, "Je Bouh", "{\"https://boubouh.txt/text.png\"}", "{\"null\"}", 1, "{\"null\"}", "Bouher", 10L },
                    { 4, 1, "Je Bouh", "{\"https://boubouh.txt/text.png\"}", "{\"null\"}", 1, "{\"https://boubouh.txt/text.png\"}", "Bouhas", 260L },
                    { 5, 1, "Je Bouh", "{\"https://boubouh.txt/text.png\"}", "{\"null\"}", 1, "{\"null\"}", "Bouhvi", 2000L },
                    { 6, 0, "Je Bouh", "{\"https://boubouh.txt/text.png\"}", "{\"null\"}", 1, "{\"null\"}", "Bouhtu", 30L }
                });

            migrationBuilder.InsertData(
                table: "CTFList",
                columns: new[] { "Id", "Dend", "Dstart", "Name", "Select" },
                values: new object[,]
                {
                    { 1, "29/05/2023 15:00:00", "29/05/2023 13:00:00", "CTFTest", 1 },
                    { 2, "24/05/2023 15:00:00", "21/05/2023 13:00:00", "CTFToust", 0 }
                });

            migrationBuilder.InsertData(
                table: "CTFListChalls",
                columns: new[] { "Id", "Actif", "Chall", "LinkedCTF", "Name", "Order", "StrictOrder" },
                values: new object[,]
                {
                    { 1, 1, "{1, 2, 4}", 1, "Je Bouh", "{1, 2, 4}", 1 },
                    { 2, 1, "{3}", 1, "JeBoude", "{3}", 0 },
                    { 3, 1, "{5}", 1, "Bouhbouh", "{5}", 0 },
                    { 4, 0, "{6}", 1, "Pasla", "{6}", 0 },
                    { 5, 0, "{6}", 2, "Pasla", "{6}", 0 }
                });

            migrationBuilder.InsertData(
                table: "CTFTeams",
                columns: new[] { "Id", "ChkPassword", "LinkedCTF", "Name", "NiceChalls" },
                values: new object[,]
                {
                    { 1, "068d23b4c3e5ba01291aef534de6e058", 1, "BlueProject", "{1, 2, 4}" },
                    { 2, "068d23b4c3e5ba01291aef534de6e058", 1, "OteriHack", "{4, 2, 3}" }
                });

            migrationBuilder.InsertData(
                table: "CTFUsers",
                columns: new[] { "Id", "AssignedChalls", "ChkPassword", "LinkedCTF", "Pseudo", "Score", "Team" },
                values: new object[,]
                {
                    { 1, "{1, 2, 4}", "068d23b4c3e5ba01291aef534de6e058", 1, "Rhenar", 2300L, 1 },
                    { 2, "{1, 4, 5}", "068d23b4c3e5ba01291aef534de6e058", 1, "Hope", 2500L, 1 },
                    { 3, "{1, 2, 3}", "068d23b4c3e5ba01291aef534de6e058", 1, "Segrard", 230L, 2 },
                    { 4, "{1, 2, 3}", "068d23b4c3e5ba01291aef534de6e058", 2, "Segrard", 230L, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTFDetailsChalls");

            migrationBuilder.DropTable(
                name: "CTFList");

            migrationBuilder.DropTable(
                name: "CTFListChalls");

            migrationBuilder.DropTable(
                name: "CTFTeams");

            migrationBuilder.DropTable(
                name: "CTFUsers");
        }
    }
}
