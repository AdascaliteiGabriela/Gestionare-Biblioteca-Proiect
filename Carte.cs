using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Carte
    {
        private static int primulId = 0;
        public int IdCarte { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        public int AnAparitie { get; set; }
        public string Cota { get; set; }

        

        public Carte(string titlu, string autor, string editura, int anAparitie, string cota)
        {
            IdCarte = ++primulId;
            Titlu = titlu;
            Autor = autor;
            Editura = editura;
            AnAparitie = anAparitie;
            Cota = cota;

        }

        public override string ToString()
        {
            return $"{Titlu} - {Autor}";
        }
    }
}
