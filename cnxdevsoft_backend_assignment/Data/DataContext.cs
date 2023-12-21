using cnxdevsoft_backend_assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace cnxdevsoft_backend_assignment.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<MathOperation> MathOperations { get; set; }
    }
}
