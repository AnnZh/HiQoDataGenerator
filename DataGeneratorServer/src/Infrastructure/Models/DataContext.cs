using System;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Models
{
    public class DataContext: DbContext
    {
        public DbSet<FieldType> Types { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
    }
}
