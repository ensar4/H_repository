using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace hackhaton_API.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Mail { get; set; }

    }
}
