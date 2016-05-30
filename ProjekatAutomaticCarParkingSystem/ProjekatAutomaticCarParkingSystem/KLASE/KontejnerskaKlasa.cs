using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAutomaticCarParkingSystem
{
    class KontejnerskaKlasa
    {
        public static List<KLASE.Isplata> isplate = new List<KLASE.Isplata>
        {
            new KLASE.Isplata(125.25m,new DateTime(2016,5,17),"Popravka vrata"),
            new KLASE.Isplata(150m,new DateTime(2016,5,30),"Popravka dizalice")

        };
        public static List<KLASE.Uplata> uplate = new List<KLASE.Uplata>
        {
            new KLASE.Uplata(400m,new DateTime(2016,5,17),"Godišnja"),
            new KLASE.Uplata(75m,new DateTime(2016,5,17),"Mjesečna")

        };
        public static List<DolazakNaPosao> dolasci = new List<DolazakNaPosao>();
        public static List<IzvjestajMajstora> izvjestajiMajstvora = new List<IzvjestajMajstora>();
        public static List<Majstor> majstori = new List<Majstor>
        {
            new Majstor("Sedin", "Pasalic", "Puhovac", "214029141", "93529kjfsa", new DateTime(1995, 2, 12), "sedin95", "1234")
        };
        public static List<Supervizor> supervizori = new List<Supervizor>();
        public static List<Korisnik> korisnici = new List<Korisnik>
        {
            //ovako dodati jos korisnika
            new Korisnik("Suljo","Suljic","0038733123456","Ahmeda Bosnjaka","AS1D564F5D4S65",new DateTime(1963,6,12),"brojvozacke","vodoinstalater","suljo","suljic"),
            new Korisnik("Adna", "Hadzialic", "00387123456", "Gbavicka", "2SD6S4D87F5S31", new DateTime(1996, 2, 17), "adnanemavozacku", "efovac", "adna96", "123456"),
            new Korisnik("Haso","Haso","0038711111111","Nema adrese","2AS45634327",new DateTime(1200,1,1),"stajeovo","penzioner","haso","1234")
        };
        public static Vlasnik vlasnik = new Vlasnik("Mujo", "Mujic", "0038762000000", "Patriotske lige 12", "1S3DG6S9DG12T2", new DateTime(1959, 7, 12),"jasamglavni","1234");
        public static Supervizor supervizor1 = new Supervizor("Merima", "Hadziabdic", "0539205923", "Sarajevo", "1241293842ds", new DateTime(1995,3,2),"merima","1234");
        public static List<DezurniRadnik> dezurniRadnici = new List<DezurniRadnik>
        {
             new DezurniRadnik("Mirza", "Alipahic", "0038762342321", "Zmaja od bosne 15", "3935290582", new DateTime(1995, 3, 5) ,"mirza95", "123456")
        };
       
    }


}
