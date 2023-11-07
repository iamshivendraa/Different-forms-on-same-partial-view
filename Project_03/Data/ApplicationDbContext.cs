using Microsoft.EntityFrameworkCore;
using Project_03.Models;

namespace Project_03.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<PersonModel> person {  get; set; }
        public DbSet<AddressModel> address { get; set; }
    }
}
