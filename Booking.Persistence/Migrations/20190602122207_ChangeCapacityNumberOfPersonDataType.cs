using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Persistence.Migrations
{
    public partial class ChangeCapacityNumberOfPersonDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfPerson",
                table: "RoomRentals",
                nullable: false,
                oldClrType: typeof(short));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Capacity",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<short>(
                name: "NumberOfPerson",
                table: "RoomRentals",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
