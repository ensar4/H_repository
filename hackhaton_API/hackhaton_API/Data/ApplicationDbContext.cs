using hackhaton_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace hackhaton_API.Data
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Home> Home { get; set; }
        public DbSet<Korisnik_Home> Korisnik_Home { get; set; }
        public DbSet<Tip> Tip { get; set; }





<<<<<<< HEAD

=======
>>>>>>> 15e330f3237f04d935425271252fc0e7cb36b099

        public ApplicationDbContext(
           DbContextOptions options) : base(options)
        {
        }



    }
}