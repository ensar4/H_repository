using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace hackhaton_API.Models
{
    public class Tip
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }


    }
}
