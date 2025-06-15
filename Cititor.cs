using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Cititor
    {
        private static int primulId = 0;
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string Telefon { get; set; }

        public Cititor(string nume, string prenume, string email, string telefon)
        {
            Id = ++primulId;
            Nume = nume;
            Prenume = prenume;
            Email = email;
            Telefon = telefon;

        }

        public override string ToString()
        {
            return $"{Nume} {Prenume} - {Email}";
        }
    }
}
