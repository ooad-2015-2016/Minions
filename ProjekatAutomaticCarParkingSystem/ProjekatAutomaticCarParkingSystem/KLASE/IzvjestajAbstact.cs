using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    abstract class IzvjestajAbstact:Izvjestaj
    {
        protected DateTime vrijemeIzvještaja;

        public abstract DateTime VrijemeIzvjestaja { get; set; }
        public IzvjestajAbstact()
        {

        }
        public IzvjestajAbstact(DateTime _vrijemeIzvjestaja)
        {
            vrijemeIzvještaja = _vrijemeIzvjestaja;
        }
    }
}
