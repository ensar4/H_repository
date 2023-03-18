using hackhaton_API.Data;
using hackhaton_API.Models;
using hackhaton_API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace hackhaton_API.Controllers
{

    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class Korisnik_HomeController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public Korisnik_HomeController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        [HttpPost]
        public Korisnik_Home Snimi([FromBody] Korisnik_HomeAddVM x)
        {
            Korisnik_Home? objekat;

            if (x.id == 0)
            {
                objekat = new Korisnik_Home();
                _dbContext.Add(objekat);
            }
            else
            {
                objekat = _dbContext.Korisnik_Home.Find(x.id);
            }

            objekat.Id = x.id;
            objekat.HomeId = x.homeId;
            objekat.KorisnikId = x.korisnikId;

            _dbContext.SaveChanges();
            return objekat;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var data = _dbContext.Korisnik_Home
                .OrderBy(s => s.Id)
                .Select(s => new Korisnik_HomeGetVM
                {
                  id=s.Id,
                  korisnikId=s.KorisnikId,
                  homeId=s.HomeId

                })
                .AsQueryable();
            return Ok(data.Take(100).ToList());
        }

      

        [HttpPost("{id}")]
        public ActionResult Delete(int id)
        {
            Korisnik_Home? obj = _dbContext.Korisnik_Home.Find(id);

            if (obj == null)
                return BadRequest("pogresan ID");

            _dbContext.Remove(obj);

            _dbContext.SaveChanges();
            return Ok(obj);
        }
    }
}
