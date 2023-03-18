using hackhaton_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace hackhaton_API.Data
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Korisnik> Korisnik { get; set; }
        //public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }

        public ApplicationDbContext(
           DbContextOptions options) : base(options)
        {
        }



    }
}