using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HTCMobile.Migrations
{
    public partial class ADdtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HtcCars",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtcWarrantyPolicy",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(maxLength: 50, nullable: true),
                    Content = table.Column<string>(maxLength: 5000, nullable: true),
                    OrderNumber = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcWarrantyPolicy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtcSchedules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<long>(nullable: true),
                    Type = table.Column<string>(nullable: false),
                    ScheduleDate = table.Column<DateTime>(nullable: false),
                    ScheduleTime = table.Column<TimeSpan>(nullable: false),
                    ServiceStaff = table.Column<string>(nullable: true),
                    AgencyId = table.Column<long>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CarId = table.Column<long>(nullable: true),
                    CarVersion = table.Column<string>(nullable: true),
                    CarLicensePlate = table.Column<string>(nullable: false),
                    CarManufactureYear = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcSchedules_HtcCars_CarId",
                        column: x => x.CarId,
                        principalTable: "HtcCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HtcSchedules_CarId",
                table: "HtcSchedules",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HtcSchedules");

            migrationBuilder.DropTable(
                name: "HtcWarrantyPolicy");

            migrationBuilder.DropTable(
                name: "HtcCars");
        }
    }
}
