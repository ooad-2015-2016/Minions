using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    abstract class Osoba:Osobe
    {
        protected String ime;
        protected String prezime;
        protected String brojTelefona;
        protected String adresa;
        protected DateTime datumRodjenja;
        protected String brojLicneKarte;

        public abstract string Ime { get; set; }
        public abstract string Prezime { get; set; }
        public abstract string BrojTelefona { get; set; }
        public abstract string Adresa { get; set; }
        public abstract DateTime DatumRodjenja { get; set; }
        public abstract string BrojLicneKarte { get; set; }

        public Osoba()
        {

        }
        public Osoba(String _ime,String _prezime, String _brojtelefona,String _adresa,String _brojlicne,DateTime _datumrodjenja)
        {
            ime = _ime;
            prezime = _prezime;
            brojTelefona = _brojtelefona;
            adresa = _adresa;
            brojLicneKarte = _brojlicne;
            datumRodjenja = _datumrodjenja;
        }

    }
}
