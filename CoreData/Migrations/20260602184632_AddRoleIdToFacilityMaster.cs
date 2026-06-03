using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreData.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleIdToFacilityMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FacilityMasters",
                table: "FacilityMasters");

            migrationBuilder.RenameTable(
                name: "FacilityMasters",
                newName: "FacilityMaster");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "FacilityMaster",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacilityMaster",
                table: "FacilityMaster",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FacilityMaster",
                table: "FacilityMaster");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "FacilityMaster");

            migrationBuilder.RenameTable(
                name: "FacilityMaster",
                newName: "FacilityMasters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacilityMasters",
                table: "FacilityMasters",
                column: "Id");
        }
    }
}
