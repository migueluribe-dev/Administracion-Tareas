using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(SELECT Id FROM AspNetRoles WHERE iD = '4c658053-1217-41fd-800f-28e4eb2c00d5')
                                    BEGIN
	                                    INSERT INTO AspNetRoles (Id, [Name], [NormalizedName])
	                                    VALUES ('4c658053-1217-41fd-800f-28e4eb2c00d5','admin','ADMIN')
                                    END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = '4c658053-1217-41fd-800f-28e4eb2c00d5'");
        }
    }
}
