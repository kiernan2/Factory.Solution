using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class Current : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Machines",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Machines",
                newName: "MachineId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Engineers",
                newName: "EngineerName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Engineers",
                newName: "EngineerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "Machines",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MachineId",
                table: "Machines",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EngineerName",
                table: "Engineers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EngineerId",
                table: "Engineers",
                newName: "Id");
        }
    }
}
