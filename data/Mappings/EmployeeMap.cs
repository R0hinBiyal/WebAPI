using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Mappings
{
    public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> tb)
        {
            tb.HasKey(x => x.Id);
            tb.Property(x => x.Name).HasMaxLength(40);
            tb.Property(x => x.Email).HasMaxLength(200);
            tb.Property(x => x.PhoneNumber).HasMaxLength(20);
            tb.Property(x => x.Address).HasMaxLength(500);
            tb.Property(x => x.Country).HasMaxLength(50);
            tb.Property(x => x.Zipcode).HasMaxLength(12);

            tb.HasIndex(x => new { x.Id, x.Name, x.Email });
        }
    }
}
