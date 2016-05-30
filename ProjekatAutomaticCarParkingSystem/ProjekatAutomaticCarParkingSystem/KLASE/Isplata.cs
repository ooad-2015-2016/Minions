using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem.KLASE
{
    class Isplata
    {
        decimal cijena;
        DateTime datumIsplate;
        String doznakaIsplate;
        public decimal Cijena { get { return cijena; }set { cijena = value; } }
        public DateTime DatumIsplate { get {  return datumIsplate;} set { datumIsplate = value; } }
        public String DoznakaIsplate { get { return doznakaIsplate; } set { doznakaIsplate= value; } }
        public Isplata()
        {
                
        }
        public Isplata(decimal _cijena, DateTime _datum, string _doznaka)
        {
            cijena = _cijena;
            datumIsplate = _datum;
            doznakaIsplate = _doznaka;
        }
        public override string ToString()
        {
            return string.Format("Isplata - datum: {0}, Doznaka: {1}, Ukupno KM: {2}", datumIsplate.ToString(), doznakaIsplate, cijena);
        }
    }
}
