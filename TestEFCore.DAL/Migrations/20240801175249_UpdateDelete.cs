using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestEFCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client",
                schema: "Work",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "Clientid",
                schema: "Work",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client",
                schema: "Work",
                table: "Projects",
                column: "Clientid",
                principalSchema: "Work",
                principalTable: "Clients",
                principalColumn: "Clintid",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client",
                schema: "Work",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "Clientid",
                schema: "Work",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client",
                schema: "Work",
                table: "Projects",
                column: "Clientid",
                principalSchema: "Work",
                principalTable: "Clients",
                principalColumn: "Clintid");
        }
    }
}
