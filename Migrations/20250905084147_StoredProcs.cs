using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace consoleAppForStudents.Migrations
{
    /// <inheritdoc />
    public partial class StoredProcs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE dbo.StudentInsert(
            @FirstName VARCHAR(50),
            @LastName VARCHAR(50),
            @School VARCHAR(50)
            )
            AS
            INSERT INTO Students (FirstName, LastName, School)
            VALUES (@FirstName, @LastName, @School)
            SELECT SCOPE_IDENTITY() AS StudentID";

            migrationBuilder.Sql(sp);

        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
