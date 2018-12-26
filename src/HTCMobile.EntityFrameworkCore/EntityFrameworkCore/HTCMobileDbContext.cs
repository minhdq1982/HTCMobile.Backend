using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HTCMobile.Authorization.Roles;
using HTCMobile.Authorization.Users;
using HTCMobile.MultiTenancy;
using HTCMobile.Model;

namespace HTCMobile.EntityFrameworkCore
{
    public class HTCMobileDbContext : AbpZeroDbContext<Tenant, Role, User, HTCMobileDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<HtcSchedule> HtcSchedules { get; set; }
        public DbSet<HtcCar> HtcCars { get; set; }
        public DbSet<HtcWarrantyPolicy> HtcWarrantyPolicys { get; set; }
        public DbSet<HtcTechnicalInstruction> HtcTechnicalInstructions { get; set; }
        public DbSet<HtcSetting> HtcSettings { get; set; }
        public DbSet<HtcSurvey> HtcSurveys { get; set; }
        public DbSet<HtcRegisterTestDrive> HtcRegisterTestDrives { get; set; }
        public DbSet<HtcAgency> HtcAgencies { get; set; }
        public DbSet<HtcCustomer> HtcCustomers { get; set; }
        public DbSet<HtcNotification> HtcNotifications { get; set; }
        public DbSet<HtcMembership> HtcMemberships { get; set; }
        public DbSet<HtcMaintenanceLevel> HtcMaintenanceLevels { get; set; }
        public DbSet<HtcInstructionBook> HtcInstructionBooks { get; set; }
        public DbSet<HtcCustomerCar> HtcCustomerCars { get; set; }
        public DbSet<HtcCarMaintenance> HtcCarMaintenances { get; set; }
        public DbSet<HtcCarDetail> HtcCarDetails { get; set; }
        public DbSet<HtcBenefitType> HtcBenefitTypes { get; set; }
        public DbSet<HtcBenefit> HtcBenefits { get; set; }

        public HTCMobileDbContext(DbContextOptions<HTCMobileDbContext> options)
            : base(options)
        {
        }
    }
}
