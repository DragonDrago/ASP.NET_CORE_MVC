using Microsoft.EntityFrameworkCore.Migrations;

namespace StaffManagement.DataAccess.Migrations
{
    public partial class SeedStaffTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Department", "Email", "FirstName", "LastName" },
                values: new object[] { 1, 1, "hello@mail.ru", "BirinchiXodim", "Gafur" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Department", "Email", "FirstName", "LastName" },
                values: new object[] { 2, 2, "go@mail.ru", "IkkinchiXodim", "Rauf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
