
using CarInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Data
{
    public class CarInsuranceContext : DbContext
    {
        public CarInsuranceContext(
            DbContextOptions<CarInsuranceContext> options)
            : base(options)
        {
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
