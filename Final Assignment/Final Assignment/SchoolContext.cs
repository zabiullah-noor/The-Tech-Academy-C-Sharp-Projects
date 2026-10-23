using Microsoft.EntityFrameworkCore;

namespace Final_Assignment
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}