using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class Vlasnik : Osoba
    {
        public override String Ime { get { return ime; } set { ime = value; } }
        public override String Prezime { get { return prezime; } set { prezime = value; } }
        public override String BrojTelefona { get { return brojTelefona; } set { brojTelefona = value; } }
        public override String Adresa { get { return adresa; } set { adresa = value; } }
        public override DateTime DatumRodjenja { get { return datumRodjenja; } set { datumRodjenja = value; } }
        public override String BrojLicneKarte { get { return brojLicneKarte; } set { brojLicneKarte = value; } }
        public Vlasnik()
        {

        }
        public Vlasnik(String _ime, String _prezime, String _brojtelefona, String _adresa, String _brojlicne, DateTime _datumrodjenja):base(_ime,_prezime,_brojtelefona,_adresa,_brojlicne,_datumrodjenja)
        {

        }
        public void GledajIzvjestaj() { }
    }
}
