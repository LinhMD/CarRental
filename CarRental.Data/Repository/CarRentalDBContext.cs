using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CarRental.Data.Model;

namespace CarRental.Data.Repository;

public class CarRentalDBContext : DbContext
{

    private readonly IConfiguration _config;

    public CarRentalDBContext(IConfiguration configuration)
    {
        _config = configuration;

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            _config["ConnectionStrings:CarRental_Azure"],
            b => b.MigrationsAssembly("CarRental.API")
                .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
    }

    public DbSet<Car> Cars { get; set; }

    public DbSet<CarCalender> CarCalenders { get; set; }

    public DbSet<CarLicense> CarLicenses { get; set; }

    public DbSet<CarModel> CarModels { get; set; }

    public DbSet<CarOwner> CarOwners { get; set; }

    public DbSet<CarType> CarTypes { get; set; }

    public DbSet<CostIncurred> CostIncurred { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Driver> Drivers { get; set; }

    public DbSet<DriverCalender> DriverCalenders { get; set; }

    public DbSet<LicenseType> LicenseTypes { get; set; }

    public DbSet<Manager> Managers { get; set; }

    public DbSet<ManufactureCompany> ManufactureCompanies { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<PaymentDetail> PaymentDetails { get; set; }

    public DbSet<RentalDetail> RentalDetails { get; set; }

    public DbSet<Route> Routes { get; set; }

    public DbSet<ShowRoom> ShowRooms { get; set; }

    public DbSet<User> Users { get; set; }

}
