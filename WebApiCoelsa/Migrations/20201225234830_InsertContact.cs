using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCoelsa.Migrations
{
    public partial class InsertContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Contacts",
            columns: new[] { "ContactId", "FirstName", "LastName", "Company", "Email", "PhoneNumber" },
            values: new object[] { 1, "Jose Maria", "Antunez", "Coelsa", "antunez@coelsa.com", "3815582300" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
