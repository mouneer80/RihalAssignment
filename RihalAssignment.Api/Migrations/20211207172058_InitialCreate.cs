using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RihalAssignment.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    class_name = table.Column<string>(type: "TEXT", nullable: true),
                    created_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    modified_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    created_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    modified_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    country_id = table.Column<int>(type: "INTEGER", nullable: false),
                    class_id = table.Column<int>(type: "INTEGER", nullable: false),
                    created_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    modified_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                    table.ForeignKey(
                        name: "FK_students_classes_class_id",
                        column: x => x.class_id,
                        principalTable: "classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_countries_country_id",
                        column: x => x.country_id,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 1, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 1" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 2, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 2" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 3, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 3" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 4, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 4" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 5, new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 5" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 1, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iran, Islamic Republic of" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 2, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azerbaijan" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 3, new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holy See (Vatican City State)" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 4, new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venezuela, Bolivarian Republic of" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 1, 5, 1, new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edna Price I" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 2, 4, 1, new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danika Schumm" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 4, 3, 1, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker Schmitt I" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 9, 1, 1, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Ima Marquardt MD" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 6, 1, 2, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alena Maryjane West III" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 7, 5, 2, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margie Bernhard" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 3, 2, 4, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amelia Schultz" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 5, 1, 4, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Esmeralda Delfina Gutkowski Sr." });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 8, 2, 4, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pearl Gutkowski" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 10, 2, 4, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viviane Jacobi" });

            migrationBuilder.CreateIndex(
                name: "IX_students_class_id",
                table: "students",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_students_country_id",
                table: "students",
                column: "country_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
