using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RolodexApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactId", "ContactedOn", "LengthOfCall", "PersonId", "Reason", "Response" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, 1, "Talked about stuff", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1);
        }
    }
}
