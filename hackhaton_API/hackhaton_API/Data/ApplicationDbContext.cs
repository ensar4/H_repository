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
        public DbSet<ProciscivacZraka> ProciscivacZraka { get; set; }
        public DbSet<RobotskiUsisivac> RobotskiUsisivac { get; set; }
        public DbSet<Klima> Klima { get; set; }
        public DbSet<MotionSensor> MotionSensor { get; set; }
        public DbSet<Tlakomjer> Tlakomjer { get; set; }









        public ApplicationDbContext(
           DbContextOptions options) : base(options)
        {
        }



    }
}