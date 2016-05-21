﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class Majstor : Osoba
    {
        String username;
        String pasword;
        public String Username { get { return username; } }
        public override String Ime { get { return ime; } set { ime = value; } }
        public override String Prezime { get { return prezime; } set { prezime = value; } }
        public override String BrojTelefona { get { return brojTelefona; } set { brojTelefona = value; } }
        public override String Adresa { get { return adresa; } set { adresa = value; } }
        public override DateTime DatumRodjenja { get { return datumRodjenja; } set { datumRodjenja = value; } }
        public override String BrojLicneKarte { get { return brojLicneKarte; } set { brojLicneKarte = value; } }
        public Majstor()
        {
                
        }
        public Majstor(String _ime, String _prezime, String _brojtelefona, String _adresa, String _brojlicne, DateTime _datumrodjenja, String _username, String _pasword)
            : base(_ime, _prezime, _brojtelefona, _adresa, _brojlicne, _datumrodjenja)
        {
            username = _username;
            pasword = _pasword;
        }
        String PromijeniPasword(String stariPw, String noviPw)
        {
            if (stariPw != this.pasword) return "Stari pasword nije tacan.";
            else this.pasword = noviPw; return "Pasword je promijenjen";
        }
        void KreirajIzvjestaj(IzvjestajMajstora izvjestaj) { KontejnerskaKlasa.izvjestajiMajstvora.Add(izvjestaj); }
    }
}
