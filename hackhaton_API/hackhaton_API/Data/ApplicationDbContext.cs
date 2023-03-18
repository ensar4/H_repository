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
<<<<<<< HEAD
        public DbSet<Pegla> Pegla { get; set; }
        public DbSet<Kuhalo> Kuhalo { get; set; }
        public DbSet<Prozori> Prozori { get; set; }
        public DbSet<SenzorDima> SenzorDima { get; set; }
        public DbSet<Vrata> Vrata { get; set; }
        
=======
        public DbSet<Tip> Tip { get; set; }





<<<<<<< HEAD

=======
>>>>>>> 15e330f3237f04d935425271252fc0e7cb36b099
>>>>>>> a143de5de3cb995039612630ca49e7e9b47507b2

        public ApplicationDbContext(
           DbContextOptions options) : base(options)
        {
        }



    }
}