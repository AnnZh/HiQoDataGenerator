using Infrastructure.Models.CustomObjectModels;
using Infrastructure.Models.ConstraintModels;
//using Infrastructure.Models.DataSetModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Models
{
    public class DataContext: DbContext
    {
        public DbSet<FieldType> Types { get; set; }
        public DbSet<Constraint> Constraints { get; set; }
        public DbSet<ConstraintValue> ConstraintValues { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
    }
}
