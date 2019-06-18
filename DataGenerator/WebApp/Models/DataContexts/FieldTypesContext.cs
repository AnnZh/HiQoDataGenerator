using System;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models.DataContexts
{
    public class FieldTypesContext: DbContext
    {
        public DbSet<FieldType> FieldTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DataGeneratorDatabase;Username=postgres;Password=denis123");
        }
    }
}
