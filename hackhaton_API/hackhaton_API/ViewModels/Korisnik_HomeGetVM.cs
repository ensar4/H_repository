using hackhaton_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace hackhaton_API.ViewModels
{
    public class Korisnik_HomeGetVM
    {
        public int id { get; set; }
        public int homeId { get; set; }
        public int korisnikId { get; set; }
    }
}
