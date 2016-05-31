using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class DolazakNaPosao
    {
        DateTime vrijeme;
        String RFID;
        public DateTime Vrijeme { get { return vrijeme; } set { vrijeme = value; } }
        public string RFID_ { get { return RFID; } set { RFID = value; } }
        public DolazakNaPosao()
        {

        }
        public DolazakNaPosao(DateTime _vrijeme, String _RFID)
        {
            RFID = _RFID;
            vrijeme = _vrijeme;
        }
        public override string ToString()
        {
            string ime = string.Format("koja nije registrovana a kod RFID-a je: {0}", this.RFID_);
                foreach (DezurniRadnik item in KontejnerskaKlasa.dezurniRadnici)
            {
                if (item.RFID == this.RFID_)
                {
                    ime = item.Ime + " " + item.Prezime;
                }
            }
            return string.Format("Osoba {0} je prosla kroz RFID reader na datum i u vrijeme: {1}", ime, this.vrijeme.ToString());
        }
    }
}
