namespace hackhaton_API.ViewModels
{
    public class KorisnikAddVM
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string brojTelefona { get; set; }
        public string mail { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public int kucaId { get; set; }
        public string nazivKuce { get; set; }
        public string adresaKuce { get; set; }
    }
}
