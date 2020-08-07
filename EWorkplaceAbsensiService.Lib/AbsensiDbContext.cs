using Com.Moonlay.Data.EntityFrameworkCore;
using EWorkplaceAbsensiService.Lib.Models;
using EWorkplaceAbsensiService.Lib.Models.Employee;
using Microsoft.EntityFrameworkCore;

namespace EWorkplaceAbsensiService.Lib
{
    public class AbsensiDbContext : StandardDbContext
    {
        public AbsensiDbContext(DbContextOptions<AbsensiDbContext> options) : base(options)
        {
        }

        public DbSet<Absensi> Absensis { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<ActivityCategory> ActivityCategory { get; set; }
        public DbSet<TaskManangement> TaskManangement { get; set; }

        public DbSet<TimeSheet> TimeSheet { get; set; }
        public DbSet<Report> Reports { get; set; }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<Division> Divisioins { get; set; }
        public DbSet<EmployeeAsset> EmployeeAssets { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<EmploymentRole> EmploymentRoles { get; set; }
        public DbSet<Religion> Religions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
