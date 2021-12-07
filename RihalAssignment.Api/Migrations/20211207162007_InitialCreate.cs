using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RihalAssignment.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Grade 1" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Grade 2" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Grade 3" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Grade 4" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Grade 5" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "El Salvador" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Bouvet Island" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "South Sudan" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Croatia" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 1, 4, 1, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Casimer Olson" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 3, 5, 1, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janelle VonRueden DDS" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 5, 3, 1, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Devon Renner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 4, 3, 2, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prof. Jeremie Eudora Zboncak" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 6, 3, 2, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rey Pollich" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 10, 3, 2, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mrs. Destini Ramona Bosco" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 2, 3, 4, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audrey Kutch Sr." });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 7, 1, 4, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sigurd McGlynn" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 8, 1, 4, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prof. Aurore Medhurst DVM" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CountryId", "DateOfBirth", "Name" },
                values: new object[] { 9, 5, 4, new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hertha Cormier" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CountryId",
                table: "Students",
                column: "CountryId");
            migrationBuilder.RenameTable("Classes", "classes");
            migrationBuilder.RenameTable("Countries", "countries");
            migrationBuilder.RenameTable("Students", "students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
