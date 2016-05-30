using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem.KLASE
{
    class Isplata
    {
        int cijena;
        DateTime datumIsplate;
        String doznakaIsplate;
        public int Cijena { get { return cijena; }set { cijena = value; } }
        public DateTime DatumIsplate { get {  return datumIsplate;} set { datumIsplate = value; } }
        public String DoznakaIsplate { get { return doznakaIsplate; } set { doznakaIsplate= value; } }
        public override string ToString()
        {
            return string.Format("Uplata - datum: {0}, Doznaka: {1}, Ukupno KM: {2}", datumIsplate, doznakaIsplate, cijena);
        }
    }
}
