using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frontends",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frontends", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Kitchens",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchens", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    birth_day = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email_address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    number_guest = table.Column<int>(type: "int", nullable: true),
                    street_address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    apt_suite = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    state = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    zip_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    room_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    room_floor = table.Column<int>(type: "int", nullable: true),
                    room_number = table.Column<int>(type: "int", nullable: true),
                    total_bill = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    payment_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    card_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    card_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    card_exp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    card_cvc = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    arrival_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    leaving_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    check_in = table.Column<bool>(type: "bit", nullable: true),
                    break_fast = table.Column<bool>(type: "bit", nullable: true),
                    lunch = table.Column<bool>(type: "bit", nullable: true),
                    dinner = table.Column<bool>(type: "bit", nullable: true),
                    cleaning = table.Column<bool>(type: "bit", nullable: true),
                    towel = table.Column<bool>(type: "bit", nullable: true),
                    s_surprise = table.Column<bool>(type: "bit", nullable: true),
                    supply_status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    food_bill = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frontends");

            migrationBuilder.DropTable(
                name: "Kitchens");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
