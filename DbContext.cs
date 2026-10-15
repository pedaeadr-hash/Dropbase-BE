using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StringConect;
namespace DbContextspace
{
    public class _Context : DbContext
    {
        //DbSets down

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(StringConect.StringConect.KeyBank); // envirommentkey after
        }
    }
}