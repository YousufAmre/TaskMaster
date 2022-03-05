using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskMaster.Migrations
{
    public partial class AddStatusSeedDataToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Statuses(Name) VALUES('To Do'); ");
            migrationBuilder.Sql("INSERT INTO Statuses(Name) VALUES('In Progress'); ");
            migrationBuilder.Sql("INSERT INTO Statuses(Name) VALUES('Done'); ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //delete for above inserts
        }
    }
}
