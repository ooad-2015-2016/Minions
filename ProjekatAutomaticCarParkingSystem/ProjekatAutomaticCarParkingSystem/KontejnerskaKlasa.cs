using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class KontejnerskaKlasa
    {
        public static List<DolazakNaPosao> dolasci = new List<DolazakNaPosao>();
        public static List<IzvjestajMajstora> izvjestajiMajstvora = new List<IzvjestajMajstora>();
        public static List<Majstor> majstori = new List<Majstor>();
        public static List<Supervizor> supervizori = new List<Supervizor>();
        public static List<Korisnik> korisnici = new List<Korisnik>();
        public static Vlasnik vlasnik = new Vlasnik("Mujo", "Mujic", "0038762000000", "Patriotske lige 12", "1S3DG6S9DG12T2", new DateTime(1959, 7, 12),"jasamglavni","1234");
            
     }
}
