using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSIMS.Migrations
{
    public partial class AddedAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "timeCreated",
                table: "Student",
                newName: "TimeCreated");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Student",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "middleName",
                table: "Student",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Student",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Student",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "emailAddress",
                table: "Student",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "Student",
                newName: "StudentId");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    StreetNumber = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Suburb = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    Postcode = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.RenameColumn(
                name: "TimeCreated",
                table: "Student",
                newName: "timeCreated");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Student",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Student",
                newName: "middleName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Student",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Student",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Student",
                newName: "emailAddress");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "studentId");
        }
    }
}
