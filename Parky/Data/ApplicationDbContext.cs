using Microsoft.EntityFrameworkCore;
using Parky.Models;
using ParkyAPI.Models;

namespace Parky.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<NationalPark> NationalParks { get; set; }
        public DbSet<Trail> Trails { get; set; }
        public DbSet<User> Users{ get; set; }
    }
}
