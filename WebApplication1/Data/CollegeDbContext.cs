using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.Data
{
    public class CollegeDbContext : DbContext
    {
        public CollegeDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Evaluation> Evaluation { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
