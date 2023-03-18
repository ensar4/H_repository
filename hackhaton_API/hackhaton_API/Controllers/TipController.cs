using hackhaton_API.Data;
using hackhaton_API.Models;
using hackhaton_API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace hackhaton_API.Controllers
{

    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class TipController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public TipController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        [HttpPost]
        public Tip Snimi([FromBody] TipAddVM x)
        {
            Tip? objekat;

            if (x.id == 0)
            {
                objekat = new Tip();
                _dbContext.Add(objekat);
            }
            else
            {
                objekat = _dbContext.Tip.Find(x.id);
            }

            objekat.Id = x.id;
            objekat.Naziv = x.naziv;
            objekat.Opis = x.opis;

            _dbContext.SaveChanges();
            return objekat;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var data = _dbContext.Tip
                .OrderBy(s => s.Id)
                .Select(s => new TipGetVM
                {
                  opis =s.Opis,
                  naziv=s.Naziv

                })
                .AsQueryable();
            return Ok(data.Take(100).ToList());
        }

      

        [HttpPost("{id}")]
        public ActionResult Delete(int id)
        {
            Tip? obj = _dbContext.Tip.Find(id);

            if (obj == null)
                return BadRequest("pogresan ID");

            _dbContext.Remove(obj);

            _dbContext.SaveChanges();
            return Ok(obj);
        }
    }
}
