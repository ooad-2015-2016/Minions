using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class Korisnik:Osoba
    {
        String username;
        String pasword;
        String zanimanje;
        String brojVozacke;
        public String Zanimanje { get { return zanimanje; } set { zanimanje = value; } }
        public String BrojVozackeDozvole { get { return brojVozacke; } set { brojVozacke = value; } }
        public String Username { get { return username; } }
        public Korisnik()
        {

        }
        public Korisnik(String _ime, String _prezime, String _brojtelefona, String _adresa, String _brojlicne, DateTime _datumrodjenja,String _brojVozacke,String _zanimanje,String _username,String _pasword)
            :base(_ime,_prezime,_brojtelefona,_adresa,_brojlicne,_datumrodjenja)
        {
            zanimanje = _zanimanje;
            brojVozacke = _brojVozacke;
            username = _username;
            pasword = _pasword;
        }
        String PromijeniPasword(String stariPw,String noviPw)
        {
            if (stariPw != this.pasword) return "Stari pasword nije tacan.";
            else this.pasword = noviPw; return "Pasword je promijenjen";
        }
    }
}
