using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RejestrOsobZaginionych.Models
{
    public class MissingModel
    {
        [Key]
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public char Plec { get; set; }
        [ForeignKey("Zdjecia")]
        public int IdPicture { get; set; }
        public string MiejsceZaginiecia { get; set; }
        public DateTime DataZaginięcia { get; set; }

    }

    
}
