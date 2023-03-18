﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace hackhaton_API.Models
{
    public class ProciscivacZraka
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Stanje { get; set; }
        public int VlaznostZraka { get; set; }

        [ForeignKey("HomeId")]
        public Home Home { get; set; }
        public int HomeId { get; set; }

        [ForeignKey("TipId")]
        public Tip Tip { get; set; }
        public int TipId { get; set; }


    }
}
