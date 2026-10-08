using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace DbContextspace
{
    public class _Context : DbContext
    {
        //DbSets down

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}