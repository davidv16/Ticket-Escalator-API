using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketEscalator.WebAPI.Migrations
{
    public partial class NullableFieldsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Assignee_FK",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeID",
                table: "Tickets",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "Assignee_FK",
                table: "Tickets",
                column: "AssigneeID",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Assignee_FK",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeID",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "Assignee_FK",
                table: "Tickets",
                column: "AssigneeID",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
