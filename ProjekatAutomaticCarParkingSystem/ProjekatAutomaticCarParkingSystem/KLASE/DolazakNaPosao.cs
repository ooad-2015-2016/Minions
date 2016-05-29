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
        public DolazakNaPosao()
        {

        }
        public DolazakNaPosao(DateTime _vrijeme, String _RFID)
        {
            RFID = _RFID;
            vrijeme = _vrijeme;
        }
    }
}
