using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class IzvjestajMajstora : IzvjestajAbstact
    {
        string idMajstora;
        string opisKvara;
        string materijal;
        string uputstvoZaRukovanje;
        string opisPopravke;
        public string OpisKvara { get { return opisKvara; } set { opisKvara = value; } }
        public string Materijal { get { return materijal; } set { materijal = value; } }
        public string UputsvoZaRukovanje { get { return uputstvoZaRukovanje; } set { uputstvoZaRukovanje = value; } }
        public string OpisPopravke { get { return opisPopravke; } set { opisPopravke = value; } }
        public string IdMajstora { get { return idMajstora; } set { idMajstora = value; } }
        public override DateTime VrijemeIzvjestaja { get { return vrijemeIzvještaja; } set { vrijemeIzvještaja = value; } }
        public IzvjestajMajstora()
        {

        }
        public IzvjestajMajstora(DateTime _vrijemeIzvjestaja,string _idMajstora, string _opisKvara, string _materijal, string _uputsvoZaRukovanje, string _opisPopravke)
            :base(_vrijemeIzvjestaja)
        {
            idMajstora = _idMajstora;
            opisKvara = _opisKvara;
            opisPopravke = _opisPopravke;
            materijal = _materijal;
            uputstvoZaRukovanje = _uputsvoZaRukovanje;
        }
    }
}
