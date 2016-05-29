using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class Automobil : Vozilo
    {
        
        string proizvodjac;
        string vrstaAutomobila;
        public override int Tezina { get { return tezina; } set { tezina = value; } }
        public string Proizvodjac { get { return proizvodjac; } set { proizvodjac = value; } }
        public override string RegistarskiBroj { get { return registarskiBroj; } set { registarskiBroj = value; } }
        public string VrstaAutomobila { get { return vrstaAutomobila; } set { vrstaAutomobila = value; } }
        public override  String IDKorisnika { get { return idKorisnika; } set { idKorisnika = value; } }
        public Automobil()
        {

        }
        public Automobil(string _idKorisnika, string _registarskiBroj, int _tezina, string _proizvodjac, string _vrsta)
            :base(_registarskiBroj,_tezina,_idKorisnika)
        {
            proizvodjac = _proizvodjac;
            vrstaAutomobila = _vrsta;
        }
    }
}
