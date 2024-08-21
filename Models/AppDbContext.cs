using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Assignment.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SkillAssesment> SkillAssessments { get; set; }
    }
}
