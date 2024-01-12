using Day10.Models;
using Microsoft.EntityFrameworkCore;

namespace Day10.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base()
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
