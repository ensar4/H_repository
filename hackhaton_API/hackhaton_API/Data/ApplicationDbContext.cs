using hackhaton_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace hackhaton_API.Data
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Korisnik> Korisnik { get; set; }
<<<<<<< HEAD
        //public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
=======
        public DbSet<Home> Home { get; set; }
        public DbSet<Korisnik_Home> Korisnik_Home { get; set; }




>>>>>>> b8af0f7d86f047302e20f31cdf5ffc608827b5a0

        public ApplicationDbContext(
           DbContextOptions options) : base(options)
        {
        }



    }
}