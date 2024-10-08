using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cozy_House.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shelter",
                columns: table => new
                {
                    Shelter_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Shelter_Name = table.Column<string>(type: "TEXT", nullable: false),
                    Shelter_Location = table.Column<string>(type: "TEXT", nullable: false),
                    Shelter_Number = table.Column<string>(type: "TEXT", nullable: false),
                    Shelter_Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelter", x => x.Shelter_ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    User_name = table.Column<string>(type: "TEXT", nullable: false),
                    User_age = table.Column<int>(type: "INTEGER", nullable: false),
                    User_Location = table.Column<string>(type: "TEXT", nullable: false),
                    Prefer = table.Column<string>(type: "TEXT", nullable: false),
                    FieldOfActivity = table.Column<string>(type: "TEXT", nullable: false),
                    User_Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Password_Check = table.Column<string>(type: "TEXT", nullable: false),
                    UsersUser_id = table.Column<int>(type: "INTEGER", nullable: true),
                    Shelter_ID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_id);
                    table.ForeignKey(
                        name: "FK_User_Shelter_Shelter_ID",
                        column: x => x.Shelter_ID,
                        principalTable: "Shelter",
                        principalColumn: "Shelter_ID");
                    table.ForeignKey(
                        name: "FK_User_User_UsersUser_id",
                        column: x => x.UsersUser_id,
                        principalTable: "User",
                        principalColumn: "User_id");
                });

            migrationBuilder.CreateTable(
                name: "animals",
                columns: table => new
                {
                    AnimalID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Animal_Name = table.Column<string>(type: "TEXT", nullable: false),
                    Species = table.Column<string>(type: "TEXT", nullable: false),
                    Breed = table.Column<string>(type: "TEXT", nullable: false),
                    Animal_Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Infection = table.Column<string>(type: "TEXT", nullable: false),
                    Vaccine = table.Column<string>(type: "TEXT", nullable: false),
                    Parasite = table.Column<string>(type: "TEXT", nullable: false),
                    User_ID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animals", x => x.AnimalID);
                    table.ForeignKey(
                        name: "FK_animals_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_animals_User_ID",
                table: "animals",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Shelter_ID",
                table: "User",
                column: "Shelter_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UsersUser_id",
                table: "User",
                column: "UsersUser_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "animals");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Shelter");
        }
    }
}
