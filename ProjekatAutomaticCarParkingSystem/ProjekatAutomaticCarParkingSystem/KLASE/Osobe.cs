using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    interface Osobe
    {
        String Ime { get; set; }
        String Prezime { get; set; }
        String BrojTelefona { get; set; }
        String Adresa { get; set; }
        DateTime DatumRodjenja { get; set; }
        String BrojLicneKarte { get; set; }
    }
}
