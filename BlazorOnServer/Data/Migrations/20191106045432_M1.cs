using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorOnServer.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "64874f59-d629-4505-9ec8-2e17260d375b", "Jane", "Smith", "Medicine" },
                    { "61625556-5bcb-462e-9b9b-574202b47626", "John", "Fisher", "Engineering" },
                    { "b2e25bf5-7f52-47bb-a527-5f852fb8d1dd", "Pamela", "Baker", "Food Science" },
                    { "36f7f8f0-6dbb-4ed3-b6fc-e6a82396e7f2", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
