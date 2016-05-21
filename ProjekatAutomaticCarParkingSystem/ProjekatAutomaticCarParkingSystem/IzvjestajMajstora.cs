using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class IzvjestajMajstora
    {
        String opisKvara;
        String materijal;
        String uputstvoZaRukovanje;
        String opisPopravke;
        public String OpisKvara { get { return opisKvara; } set { opisKvara = value; } }
        public String Materijal { get { return materijal; } set { materijal = value; } }
        public String UputsvoZaRukovanje { get { return uputstvoZaRukovanje; } set { uputstvoZaRukovanje = value; } }
        public String OpisPopravke { get { return opisPopravke; } set { opisPopravke = value; } }
        public IzvjestajMajstora()
        {

        }
        public IzvjestajMajstora(String _opisKvara,String _materijal,String _uputsvoZaRukovanje, String _opisPopravke)
        {
            opisKvara = _opisKvara;
            opisPopravke = _opisPopravke;
            materijal = _materijal;
            uputstvoZaRukovanje = _uputsvoZaRukovanje;
        }
    }
}
