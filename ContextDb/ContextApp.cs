using Microsoft.EntityFrameworkCore;
using PayxApi.Models;

namespace PayxApi.ContextDb
{
    public class ContextApp : DbContext
    {
        public ContextApp(DbContextOptions<ContextApp> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<WorkingDays> workingDays { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<AccountDetails> AccountDetails { get; set; }
        public DbSet<PayLevel> PayLevels { get; set; }
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<AllowancePayLevel> AllowancePayLevels { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PositionAllowance> PositionAllowances { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<OtherDeduction> OtherDeductions { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Ledger> Ledgers { get; set; }
        public DbSet<LedgerAdd> LedgerAdds { get; set; }
        public DbSet<LedgerDeduction> LedgerDeductions { get; set; }
    }
}