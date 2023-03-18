﻿using Azure.Core;
using hackhaton_API.Data;
using hackhaton_API.Models;
using hackhaton_API.ViewModels;
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

            //var usernameProvjera = _dbContext.Korisnik.Select(k=>k.Username).FirstOrDefault();
            //if(usernameProvjera!=x.Username)
            //{
            //    return NotFound();
            //}

            //var passwordProvjera = _dbContext.Korisnik.Select(k => k.Password).FirstOrDefault();
            //if (passwordProvjera != x.Password)
            //{
            //    return Unauthorized();
            //}

            if (logiraniKorisnik == null)
            {
                //pogresan username i password
                return BadRequest();
            }
           

            return Ok();
        }

        [HttpPost]
        public ActionResult Snimi([FromBody] KorisnikAddVM x)
        {
            Korisnik? objekat;

            if (x.id == 0)
            {
                objekat = new Korisnik();
                _dbContext.Add(objekat);
            }
            else
            {
                objekat = _dbContext.Korisnik.Find(x.id);
            }

            objekat.Id = x.id;
            objekat.Ime = x.ime;
            objekat.Prezime = x.prezime;
            objekat.Mail = x.mail;
            objekat.Password = x.password;
            objekat.Username = x.username;
            objekat.BrojTelefona = x.brojTelefona;


            _dbContext.SaveChanges();
            return Ok(objekat);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var data = _dbContext.Korisnik
                .OrderBy(s => s.Id)
                .Select(s => new KorisnikGetVM
                {
                    id=s.Id,
                    ime=s.Ime,
                    prezime=s.Prezime,
                    brojTelefona=s.BrojTelefona,
                    mail=s.Mail

                })
                .AsQueryable();
            return Ok(data.Take(100).ToList());
        }



        [HttpPost("{id}")]
        public ActionResult Delete(int id)
        {
            Korisnik? obj = _dbContext.Korisnik.Find(id);

            if (obj == null)
                return BadRequest("pogresan ID");

            _dbContext.Remove(obj);

            _dbContext.SaveChanges();
            return Ok(obj);
        }


    }
}

