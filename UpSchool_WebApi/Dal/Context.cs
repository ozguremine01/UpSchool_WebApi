using Microsoft.EntityFrameworkCore;
using UpSchool_WebApi.Dal.Entities;

namespace UpSchool_WebApi.Dal
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-H7B28ES;database=DBCoreUpSchoolApi; integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
