using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem.KLASE
{
    public class Uplata
    {
        decimal vrijednost;
        DateTime datumUplate;
        String doznakaUplate;
        public decimal Vrijednost{ get { return vrijednost; } set{ vrijednost= value; } }
        public DateTime DatumUplate { get { return datumUplate; } set { datumUplate = value; } }
        public String DoznakaUplate { get { return doznakaUplate; } set { doznakaUplate = value; } }
        public override string ToString()
        {
            return string.Format("Uplata - datum: {0}, Doznaka: {1}, Ukupno KM: {2}", datumUplate.ToString(), doznakaUplate, vrijednost);
        }
    }
}
