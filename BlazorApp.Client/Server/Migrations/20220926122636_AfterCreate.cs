using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Client.Server.Migrations
{
    public partial class AfterCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBrith",
                table: "Employees",
                newName: "DateOfBirth");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "Address", "Phone" },
                values: new object[] { "21st baker street", "4578456695" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Address", "Phone" },
                values: new object[] { "21st baker street", "4578456695" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "Address", "Phone" },
                values: new object[] { "21st baker street", "4578456695" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "Address", "Phone" },
                values: new object[] { "21st baker street", "4578456695" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Employees",
                newName: "DateOfBrith");
        }
    }
}
