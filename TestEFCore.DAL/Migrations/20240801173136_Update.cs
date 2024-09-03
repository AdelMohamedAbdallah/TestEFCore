using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestEFCore.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client",
                schema: "Work",
                table: "Projects");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client",
                schema: "Work",
                table: "Projects",
                column: "Clientid",
                principalSchema: "Work",
                principalTable: "Clients",
                principalColumn: "Clintid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client",
                schema: "Work",
                table: "Projects");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client",
                schema: "Work",
                table: "Projects",
                column: "Clientid",
                principalSchema: "Work",
                principalTable: "Clients",
                principalColumn: "Clintid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
