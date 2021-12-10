using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RihalAssignment.Api.Migrations
{
    public partial class IntialCreation : Migration
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
                values: new object[] { 1, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 1" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 2, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 2" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 3, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 3" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 4, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 4" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 5, new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 5" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "created_date", "modified_date", "class_name" },
                values: new object[] { 6, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grade 6" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 1, new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niger" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 2, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timor-Leste" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 3, new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgin Islands, British" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 4, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Botswana" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 5, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonaire, Sint Eustatius and Saba" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 6, new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Singapore" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 7, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belarus" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 8, new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinique" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 9, new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guernsey" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "created_date", "modified_date", "name" },
                values: new object[] { 10, new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montserrat" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 10, 4, 1, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwood Beatty" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 72, 5, 8, new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Osvaldo Frankie Kreiger Sr." });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 68, 2, 8, new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Izabella Feest" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 60, 1, 8, new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jermain Quitzon" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 59, 5, 8, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ms. Ophelia Bernhard" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 24, 5, 8, new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelle O'Connell" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 21, 1, 8, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Ottilie Orn DDS" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 9, 2, 8, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mrs. Anibal Roger Quitzon DVM" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 3, 4, 8, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Carmel Denesik" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 1, 5, 8, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Alvera Leannon" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 100, 5, 7, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karolann Cruickshank" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 97, 1, 7, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miss Nat Alexys McGlynn" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 57, 3, 7, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miss Rebeca Russel" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 56, 6, 7, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shanelle Elvera Pacocha Sr." });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 54, 1, 7, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javon Schuster" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 44, 4, 7, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordy Batz" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 28, 6, 7, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miss Darby Magdalena Lakin IV" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 25, 5, 7, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telly Wilkinson" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 23, 1, 7, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed Swaniawski" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 77, 1, 6, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauryn Astrid Wintheiser Jr." });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 71, 4, 6, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Chasity Henry Bode" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 50, 6, 6, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miss Martina Kristy Gislason II" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 74, 1, 8, new DateTime(2020, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toy Ritchie" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 35, 4, 6, new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chaya Kassulke" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 87, 3, 8, new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mrs. Eloisa Alek Hansen" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 99, 2, 8, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prof. Alfreda Hickle IV" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 75, 3, 10, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kacey Quigley" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 70, 1, 10, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaida Kilback" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 69, 5, 10, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jovanny Jude Rempel DVM" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 62, 6, 10, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathanael Terrell Kerluke I" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 61, 1, 10, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassandra Larkin" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 55, 3, 10, new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mrs. Ima Oliver Abernathy" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 51, 3, 10, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chaim Christiansen" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 18, 3, 10, new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paxton Hand Jr." });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 4, 5, 10, new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holly Osinski" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 2, 2, 10, new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Vernon Ambrose Douglas" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 95, 1, 9, new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dayana Jacobs" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 94, 1, 9, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenora Lubowitz" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 86, 4, 9, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hector Fisher" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 81, 6, 9, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdullah Rolfson" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 79, 3, 9, new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erna Hills" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 73, 1, 9, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miss Kobe Anastasia Hoppe IV" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 65, 6, 9, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Sylvan Gilbert Baumbach MD" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 47, 1, 9, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javonte Zemlak" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 40, 3, 9, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dillan Gorczany" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 36, 1, 9, new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyla Hauck" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 19, 6, 9, new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Itzel Monahan II" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 98, 2, 8, new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giles Dickens" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 22, 3, 6, new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Maureen Dolly Halvorson" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 11, 2, 6, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dan Cummings" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 89, 2, 5, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Priscilla Pollich" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 48, 1, 3, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miss Krystal Heath Satterfield" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 7, 1, 3, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mrs. Enrico Geo Goyette" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 5, 4, 3, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jasmin Kertzmann PhD" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 76, 5, 2, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noemi Cole" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 63, 6, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corene Jacobs" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 58, 5, 2, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ms. Elda Ethyl Ullrich I" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 49, 2, 2, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriella Effertz" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 45, 5, 2, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maida Shields" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 42, 3, 2, new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Trudie Johnston" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 32, 4, 2, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linwood Reinger" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 12, 2, 2, new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rylan Jerde II" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 6, 4, 2, new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Walker Lemuel Hessel" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 96, 4, 1, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jannie Pouros" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 93, 1, 1, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaylin Krajcik" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 80, 6, 1, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johann Tomas Hane Jr." });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 41, 1, 1, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jon Williamson" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 34, 5, 1, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ms. Harmony Mallory Hickle" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 27, 1, 1, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rita Prohaska II" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 26, 2, 1, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garth Oscar Jenkins DDS" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 20, 2, 1, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hadley Rodriguez" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 16, 2, 1, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosemary Grant" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 52, 6, 3, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arvel VonRueden" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 53, 2, 3, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prof. Cesar Judd Mosciski V" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 64, 3, 3, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Broderick Klein" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 82, 1, 3, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audie Johnson" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 88, 3, 5, new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Susana Mayert II" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 83, 4, 5, new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scarlett Monahan" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 78, 4, 5, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto Wiegand" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 46, 1, 5, new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lillie Jaskolski" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 38, 1, 5, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wiley Erin Braun IV" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 37, 5, 5, new DateTime(2020, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adeline Swaniawski V" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 31, 5, 5, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavada Rohan" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 30, 1, 5, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miss Marielle Peyton Shields DVM" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 29, 2, 5, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richmond Durgan" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 14, 2, 5, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prof. Jabari Pierre Casper" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 84, 5, 10, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orie Bartell" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 13, 1, 5, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brice Grimes" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 67, 2, 4, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hilma Fadel" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 66, 6, 4, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mrs. Marcos Block" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 43, 1, 4, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ms. Ally Delilah Kovacek" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 39, 5, 4, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Emmett Pinkie Mosciski" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 33, 1, 4, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenny Schuppe" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 17, 6, 4, new DateTime(2020, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sammie Dickinson" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 15, 2, 4, new DateTime(2020, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hal Mayert" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 92, 4, 3, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prof. Lloyd Kozey II" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 91, 1, 3, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed Emelie Heaney DDS" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 85, 5, 3, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prof. Lawson Hackett" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 8, 2, 5, new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dashawn Bergnaum" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "class_id", "country_id", "created_date", "date_of_birth", "modified_date", "name" },
                values: new object[] { 90, 3, 10, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marina Bartell" });

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
