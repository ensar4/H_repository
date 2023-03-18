using Azure.Core;
using hackhaton_API.Data;
using hackhaton_API.Models;
using Microsoft.AspNetCore.Mvc;


namespace FIT_Api_Example.Modul0_Autentifikacija.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")] 
    public class KorisnikController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public KorisnikController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

       public class LoginVM
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [HttpPost]
        public ActionResult<Korisnik> Login([FromBody] LoginVM x)
        {
            //1- provjera logina
            Korisnik? logiraniKorisnik = _dbContext.Korisnik
                .FirstOrDefault(k =>
                k.Username != null && k.Username == x.Username && k.Password == x.Password);

            var usernameProvjera = _dbContext.Korisnik.Select(k=>k.Username).SingleOrDefault();
            if(usernameProvjera!=x.Username)
            {
                return NotFound();
            }

            var passwordProvjera = _dbContext.Korisnik.Select(k => k.Password).SingleOrDefault();
            if (passwordProvjera != x.Password)
            {
                return Unauthorized();
            }

            if (logiraniKorisnik == null)
            {
                //pogresan username i password
                return BadRequest();
            }
           

            return Ok();
        }

        

       
    }
}

