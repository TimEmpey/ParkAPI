using Microsoft.EntityFrameworkCore.Migrations;

namespace National.Migrations
{
    public partial class Context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Name", "ParkId", "Size", "Type" },
                values: new object[] { 2, "Climbing", 1, 3, "Outdoors" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Camping", "Name", "State" },
                values: new object[,]
                {
                    { 2, "No", "Grand Canyon", "Arizona" },
                    { 3, "Yes", "Yosemite", "California" },
                    { 4, "No", "Zion", "Virginia" },
                    { 5, "Yes", "Rocky Mountain", "Colorado" },
                    { 6, "Yes", "Glacier", "Montana" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Name", "ParkId", "Size", "Type" },
                values: new object[,]
                {
                    { 3, "Tour", 2, 30, "Outdoors" },
                    { 5, "Hiking", 3, 10, "Outdoors" },
                    { 6, "Camping", 3, 6, "Outdoors" },
                    { 7, "Kayaking", 4, 2, "Outdoors" },
                    { 8, "Food", 4, 5, "Indoors" },
                    { 9, "Climbing", 5, 3, "Outdoors" },
                    { 10, "Camping", 5, 6, "Outdoors" },
                    { 11, "Kayaking", 6, 2, "Outdoors" },
                    { 12, "Food", 6, 5, "Indoors" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);
        }
    }
}
