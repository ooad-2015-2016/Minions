using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class DezurniRadnik:Osoba
    {
        String pasword;
        String username;
        public String Username { get { return username; } }
        public override String Ime { get { return ime; } set { ime = value; } }
        public override String Prezime { get { return prezime; } set { prezime = value; } }
        public override String BrojTelefona { get { return brojTelefona; } set { brojTelefona = value; } }
        public override String Adresa { get { return adresa; } set { adresa = value; } }
        public override DateTime DatumRodjenja { get { return datumRodjenja; } set { datumRodjenja = value; } }
        public override String BrojLicneKarte { get { return brojLicneKarte; } set { brojLicneKarte = value; } }
        public string Password { get { return pasword; } }
        public DezurniRadnik()
        {

        }
        public DezurniRadnik(String _ime, String _prezime, String _brojtelefona, String _adresa, String _brojlicne, DateTime _datumrodjenja, String _brojVozacke, String _zanimanje, String _username, String _pasword):base(_ime,_prezime,_brojtelefona,_adresa,_brojlicne,_datumrodjenja)
        {
            
            username = _username;
            pasword = _pasword;
        }
        String PromijeniPasword(String stariPw, String noviPw)
        {
            if (stariPw != this.pasword) return "Stari pasword nije tacan.";
            else this.pasword = noviPw; return "Pasword je promijenjen";
        }
        //Ovisno od toga da li treba zvati majstora ili supervizora da mu se prjavi krar
        //vraca broj telefona supervizora / majstora
        String Poziv(Type tip)
        {
            if (tip == typeof(Majstor))
                foreach (Majstor majstor in KontejnerskaKlasa.majstori)
                {
                    return majstor.BrojTelefona;
                }
            else if (tip ==typeof(Supervizor))
            {
                foreach (Supervizor supervizor in KontejnerskaKlasa.supervizori)
                {
                    return supervizor.BrojTelefona;
                }
            }

            return null;
         }


    }
}
