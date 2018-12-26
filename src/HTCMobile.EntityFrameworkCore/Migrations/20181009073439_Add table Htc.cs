using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HTCMobile.Migrations
{
    public partial class AddtableHtc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HtcAgencies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcAgencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtcBenefitTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcBenefitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtcCarDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<long>(nullable: true),
                    Version = table.Column<string>(nullable: false),
                    YearOfProduction = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcCarDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcCarDetails_HtcCars_CarId",
                        column: x => x.CarId,
                        principalTable: "HtcCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HtcCustomers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IdentityCard = table.Column<string>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 65536, nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcCustomers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtcInstructionBooks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<long>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    OrderNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcInstructionBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcInstructionBooks_HtcCars_CarId",
                        column: x => x.CarId,
                        principalTable: "HtcCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HtcMaintenanceLevels",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcMaintenanceLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtcSettings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurveyCarNewTime = table.Column<string>(nullable: true),
                    SurveyCarMaintenaceTime = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtcTechnicalInstructions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    Image = table.Column<string>(maxLength: 500, nullable: true),
                    Content = table.Column<string>(nullable: true),
                    OrderNumber = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcTechnicalInstructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtcCustomerCars",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<long>(nullable: true),
                    AgencyId = table.Column<long>(nullable: true),
                    LicensePlate = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcCustomerCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcCustomerCars_HtcAgencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "HtcAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HtcCustomerCars_HtcCars_CarId",
                        column: x => x.CarId,
                        principalTable: "HtcCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HtcRegisterTestDrives",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gender = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CarId = table.Column<long>(nullable: true),
                    AgencyId = table.Column<long>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: true),
                    ConfirmationDate = table.Column<DateTime>(nullable: true),
                    ConfirmationBy = table.Column<long>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcRegisterTestDrives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcRegisterTestDrives_HtcAgencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "HtcAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HtcRegisterTestDrives_HtcCars_CarId",
                        column: x => x.CarId,
                        principalTable: "HtcCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HtcSurveys",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SurveyType = table.Column<string>(nullable: true),
                    SurveyDate = table.Column<DateTime>(nullable: true),
                    CarId = table.Column<long>(nullable: true),
                    AgencyId = table.Column<long>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcSurveys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcSurveys_HtcAgencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "HtcAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HtcSurveys_HtcCars_CarId",
                        column: x => x.CarId,
                        principalTable: "HtcCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HtcBenefits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BenefitTypeId = table.Column<long>(nullable: true),
                    BenefitName = table.Column<string>(nullable: true),
                    BenefitDetail = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcBenefits_HtcBenefitTypes_BenefitTypeId",
                        column: x => x.BenefitTypeId,
                        principalTable: "HtcBenefitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HtcMemberships",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<long>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    BenefitTypeId = table.Column<long>(nullable: true),
                    CarId = table.Column<long>(nullable: true),
                    CumulativePoint = table.Column<double>(nullable: true),
                    PeriodPoint = table.Column<double>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcMemberships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcMemberships_HtcBenefitTypes_BenefitTypeId",
                        column: x => x.BenefitTypeId,
                        principalTable: "HtcBenefitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HtcMemberships_HtcCars_CarId",
                        column: x => x.CarId,
                        principalTable: "HtcCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HtcMemberships_HtcCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "HtcCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HtcNotifications",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<long>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ShortContent = table.Column<string>(nullable: true),
                    FullContent = table.Column<string>(nullable: true),
                    MessageType = table.Column<string>(nullable: true),
                    SentDate = table.Column<DateTime>(nullable: true),
                    ToPerson = table.Column<long>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcNotifications_HtcCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "HtcCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HtcCarMaintenances",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<long>(nullable: true),
                    MaintenanceLevelId = table.Column<long>(nullable: true),
                    LaborCost = table.Column<double>(nullable: true),
                    CostOfMaterial = table.Column<double>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: true),
                    Taxes = table.Column<double>(nullable: true),
                    TotalAfterTaxes = table.Column<double>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtcCarMaintenances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtcCarMaintenances_HtcCars_CarId",
                        column: x => x.CarId,
                        principalTable: "HtcCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HtcCarMaintenances_HtcMaintenanceLevels_MaintenanceLevelId",
                        column: x => x.MaintenanceLevelId,
                        principalTable: "HtcMaintenanceLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HtcSchedules_CustomerId",
                table: "HtcSchedules",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcBenefits_BenefitTypeId",
                table: "HtcBenefits",
                column: "BenefitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcCarDetails_CarId",
                table: "HtcCarDetails",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcCarMaintenances_CarId",
                table: "HtcCarMaintenances",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcCarMaintenances_MaintenanceLevelId",
                table: "HtcCarMaintenances",
                column: "MaintenanceLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcCustomerCars_AgencyId",
                table: "HtcCustomerCars",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcCustomerCars_CarId",
                table: "HtcCustomerCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcInstructionBooks_CarId",
                table: "HtcInstructionBooks",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcMemberships_BenefitTypeId",
                table: "HtcMemberships",
                column: "BenefitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcMemberships_CarId",
                table: "HtcMemberships",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcMemberships_CustomerId",
                table: "HtcMemberships",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcNotifications_CustomerId",
                table: "HtcNotifications",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcRegisterTestDrives_AgencyId",
                table: "HtcRegisterTestDrives",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcRegisterTestDrives_CarId",
                table: "HtcRegisterTestDrives",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcSurveys_AgencyId",
                table: "HtcSurveys",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HtcSurveys_CarId",
                table: "HtcSurveys",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_HtcSchedules_HtcCustomers_CustomerId",
                table: "HtcSchedules",
                column: "CustomerId",
                principalTable: "HtcCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HtcSchedules_HtcCustomers_CustomerId",
                table: "HtcSchedules");

            migrationBuilder.DropTable(
                name: "HtcBenefits");

            migrationBuilder.DropTable(
                name: "HtcCarDetails");

            migrationBuilder.DropTable(
                name: "HtcCarMaintenances");

            migrationBuilder.DropTable(
                name: "HtcCustomerCars");

            migrationBuilder.DropTable(
                name: "HtcInstructionBooks");

            migrationBuilder.DropTable(
                name: "HtcMemberships");

            migrationBuilder.DropTable(
                name: "HtcNotifications");

            migrationBuilder.DropTable(
                name: "HtcRegisterTestDrives");

            migrationBuilder.DropTable(
                name: "HtcSettings");

            migrationBuilder.DropTable(
                name: "HtcSurveys");

            migrationBuilder.DropTable(
                name: "HtcTechnicalInstructions");

            migrationBuilder.DropTable(
                name: "HtcMaintenanceLevels");

            migrationBuilder.DropTable(
                name: "HtcBenefitTypes");

            migrationBuilder.DropTable(
                name: "HtcCustomers");

            migrationBuilder.DropTable(
                name: "HtcAgencies");

            migrationBuilder.DropIndex(
                name: "IX_HtcSchedules_CustomerId",
                table: "HtcSchedules");
        }
    }
}
