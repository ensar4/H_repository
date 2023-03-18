using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace hackhaton_API.Models
{
    public class Korisnik_Home
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("HomeId")]
        public Home Home { get; set; }
        public int HomeId { get; set; }

        [ForeignKey("KorisnikId")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }

    }
}
