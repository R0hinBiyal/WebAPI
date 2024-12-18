using api.Mappings;
using Microsoft.EntityFrameworkCore;
using models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Employee> Employee { get; set; }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           new EmployeeMap(modelBuilder.Entity<Employee>());

        }
    }
}
