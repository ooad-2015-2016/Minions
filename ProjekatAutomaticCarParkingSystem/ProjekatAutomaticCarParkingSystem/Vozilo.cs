using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    public abstract class Vozilo : IVozila
    {
        protected string idKorisnika;
        protected string registarskiBroj;
        protected int tezina;
        abstract public int Tezina { get; set; }
        abstract public string RegistarskiBroj { get; set; }
        abstract public string IDKorisnika { get; set; }
        public Vozilo()
        {

        }
        public Vozilo(string _registarskiBroj, int _tezina, string _idKorisnika)
        {
            registarskiBroj = _registarskiBroj;
            tezina = _tezina;
            idKorisnika = _idKorisnika;
     
        }
    }
}
