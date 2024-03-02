using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagementSystemII.Migrations
{
    /// <inheritdoc />
    public partial class initialschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomStatus",
                columns: table => new
                {
                    RID = table.Column<Guid>(type: "TEXT", nullable: false),
                    CheckIn = table.Column<string>(type: "TEXT", nullable: true),
                    CheckOut = table.Column<string>(type: "TEXT", nullable: true),
                    RNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Available = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomStatus", x => x.RID);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    UserAccountID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.UserAccountID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RID = table.Column<Guid>(type: "TEXT", nullable: false),
                    RNumber = table.Column<string>(type: "TEXT", nullable: true),
                    RBed = table.Column<string>(type: "TEXT", nullable: true),
                    RPrice = table.Column<string>(type: "TEXT", nullable: true),
                    RStatusRID = table.Column<Guid>(type: "TEXT", nullable: true),
                    CheckIn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CheckOut = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RID);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomStatus_RStatusRID",
                        column: x => x.RStatusRID,
                        principalTable: "RoomStatus",
                        principalColumn: "RID");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IdentityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CardNo = table.Column<string>(type: "TEXT", nullable: true),
                    Position = table.Column<string>(type: "TEXT", nullable: true),
                    UserAccountID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.IdentityId);
                    table.ForeignKey(
                        name: "FK_Employees_UserAccounts_UserAccountID",
                        column: x => x.UserAccountID,
                        principalTable: "UserAccounts",
                        principalColumn: "UserAccountID");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RoomRID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Nationality = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    NICNO = table.Column<string>(type: "TEXT", nullable: true),
                    DateofBirth = table.Column<string>(type: "TEXT", nullable: true),
                    CheckIn = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CsId);
                    table.ForeignKey(
                        name: "FK_Customers_Rooms_RoomRID",
                        column: x => x.RoomRID,
                        principalTable: "Rooms",
                        principalColumn: "RID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoomRID",
                table: "Customers",
                column: "RoomRID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserAccountID",
                table: "Employees",
                column: "UserAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RStatusRID",
                table: "Rooms",
                column: "RStatusRID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "RoomStatus");
        }
    }
}
