using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Imprumut
    {
        private static int primulId = 0;
        public int IdImprumut { get; set; }
        public Cititor Cititor { get; set; }
        public Carte Carte { get; set; }
        public DateTime DataImprumut { get; set; }
        public DateTime DataScadenta { get; set; }
        public DateTime? DataReturnare { get; set; }

        public Imprumut(Cititor cititor, Carte carte, DateTime dataImprumut, DateTime dataScadenta, DateTime? dataReturnare = null)
        {
            IdImprumut = ++primulId;
            Cititor = cititor;
            Carte = carte;
            DataImprumut = dataImprumut;
            DataScadenta = dataScadenta;
            DataReturnare = dataReturnare;
        }

        public override string ToString()
        {
            string status = DataReturnare.HasValue ? $"Returnată pe {DataReturnare.Value.ToShortDateString()}" : "Încă nereturnată";
            return $"[{IdImprumut}] {Cititor.Nume} {Cititor.Prenume} a împrumutat „{Carte.Titlu}” până la {DataScadenta.ToShortDateString()} ({status})";
        }
    }
}
