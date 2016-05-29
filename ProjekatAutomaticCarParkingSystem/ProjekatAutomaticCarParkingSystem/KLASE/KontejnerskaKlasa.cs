﻿using System;
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
        public static DezurniRadnik dezurni_radnik1 = new DezurniRadnik("Mirza", "Alipahic", "062 342 321", "Zmaja od bosne 15", "3935290582", new DateTime(1995, 3, 5),"9182490183f","radnik" ,"mirza95", "123456");
        public static Supervizor supervizor1 = new Supervizor("Merima", "Hadziabdic", "0539205923", "Sarajevo", "1241293842ds", new DateTime(1995,3,2),"merima","1234");
        public static Majstor majstor1 = new Majstor("Sedin", "Pasalic", "Puhovac", "214029141", "93529kjfsa", new DateTime(1995, 2, 12), "sedin95", "1234");
        //posto su objekti static dodajemo clanove u liste unutar ove metode, da bi se moglo pristupati isto kao i u drugim dijelovima koda 
        public static void DodavnjeClanovaListe()
        {
            korisnici.Add(new Korisnik("Adna", "Hadzialic", "00387123456", "Gbavicka", "2SD6S4D87F5S31", new DateTime(1996, 2, 17), "adnanemavozacku", "efovac", "adna96", "123456"));
        }
    }


}
