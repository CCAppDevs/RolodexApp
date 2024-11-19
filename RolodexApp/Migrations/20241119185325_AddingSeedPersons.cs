using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RolodexApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeedPersons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Address1", "Address2", "City", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "State" },
                values: new object[,]
                {
                    { 1, null, null, null, "jesse@jesse.com", "Jesse", "Harlan", "1234567890", null, null },
                    { 2, "123 Someplace Ln", null, "No Place", null, "Tom", "Jones", "1234567891", "12345", "NY" },
                    { 3, "123 Someplace Ln", null, "No Place", null, "Sue", "Jones", "1234567892", "12345", "NY" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 3);
        }
    }
}
