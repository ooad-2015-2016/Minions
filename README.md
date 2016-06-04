# **Automatic car parking system**

1. Sedin Pašalić
2. Mirza Alispahić
3. Adna Hadzialić
4. Merima Hadziabdić

## **Opis teme**

Automatic car parking system predstavlja sistem automatskog pronalaženja mjesta za parkiranje i parkiranja automobila bez dodira vlasnika automobila sa unutrašnjosti parkirališta. Problem koji je do sada imao supervizor je što primarno nije imao uvid u podatke korisnika koji koristi parking, greške prilikom plaćajna istog, greške prilikom pronalazenja slobodnih mjesta i sl. Informacioni sistem će uveliko olakšati upravljanje dostupnim parking mjestima, upravljanje plaćanjem na bazi godišnjeg, mjesečnog, dnevnog ili eventualno obračuna vremena po satu, identifikaciju korisnika, *koja je ovdje i najbitnija stavka*. Takođe biti će omogućena opcija dostavljanja podataka o poslovanju firme **_SACP_** vlasniku iste. Sistem ce podržavati i opciju slanja obavještenja korisniku o eventualnom isteku najma parkinga i obračunu za prekoračenje - ukoliko do njega dođe. Omogućeno je i izdavanje fiskalnog računa korisniku te identifikacijskog koda svakom korisniku prilikom svakog korišenja parkirališta. 

## **Procesi** 

**Registracija korisnika**
Korisnik koji dolazi prvi put biva registrovan od strane dežurnog radnika koji mu izrađuje i člansku karticu. Prilikom registracije korisnik daje svoje lične podatke koje dežurni radnik unosi u sistem, također daje i svoj otisak prsta, što se koristi kao zadnji nivo identifikacije ukoliko korisnik izgubi člansku karticu ili identifikacijski kod koji dobije prilikom svakog korištenja.

**Provjera slobodnih mjesta na parkingu**
Prilikom zahtjeva korisnika za parking, sistem provjerava da li ima slobodnih mjesta. U slučaju da ima, korisnik uplaćuje parking. U suprotnom, korisniku se šalje poruka da je parking pun.

**Uplata parkirališta**
Korisnik pomoću automata uplaćuje parking. Može uplatiti do 23 sata i to će biti obračunato na osnovu cijene za parking po satnici, može uplatiti dnevni parking odnosno broj dana - obračun na osnovu cijene za mjesečni parking, može uplatiti kao godišnju kartu naravno po unaprijed određenoj cijeni godišnje karte.
Korsniku je omogućena uplata od strane automata pomoću kartice ili papirne novčanice - odnosno kovanice. Dopušena valuta je samo BAM. 

**Korisnik koristi parkiralište**
Korisnik dolazi automobilom u prostor odakle automobil preuzima sistem nakon identifikacije korisnika i provjere da li je parking uplaćen. Korisnik dobiva potvrdu o ostavljanju automobila u vidu identifikacionog koda koji će kasnije koristiti prilikom preuzimanja automobila te bira opciju da li želi da bude obaviješten o isteku parkinga na broj telefona koji je dao prilikom registracije.

**Formiranje izvješća**
Vlasnik firme ima mogućnost formiranja izvještaja poslovanja sa svim transakcijama. Vlasnik pristupa svom računu pomoću njegovog identifikacijskog koda te ima mogućnost da vidi izvještaj u vidu dnevnog izvještaja, mjesečnog te godišnjeg.

**Pregled dolaska na posao**
Supervizor ima mogućnost da provjeri kada je koji dežurni radnik došao na posao.

**Registracija radnika prilikom dolaska na posao**
Radnik prilikom dolaska na posao prolazi kroz tripod sistem koji se otvara kada ubaci identifikacionu karticu koja mu je dodijeljena.

**Prijava kvara**
Dežurni radnik, u slučaju kvara na sistemu, prijavljuje kvar te poziva majstora za popravak.



## **Funkcionalnosti**
- Mogucnost uplate parkinga na satnoj,dnevnoj,mjesečnoj ili godišnjoj bazi sa posebnim pogodnostima za svaku.
- Mogucnost korištenja parkinga u toku čitavog dana.
- Mogucnost dobivanja informacije o isteku uplacenog parkinga.
- Mogucnost dobivanja izvještaja o poslovanju sa svim transakcijama.
- Mogucnost provjere kad je koji radnik došao na posao.

## **Akteri**

**Supervizor**
Osoba nadgleda dolazak radnika na posao te na kraju svakog dana novac odnosi u banku i polaže na račun.

**Dežurni radnik**
Osoba vrši registraciju novih korisnika te nadgleda sistem. U slučaju kvara na sistemu,kvar prijavljuje te poziva majstora za popravke.

**Korisnik**
Osoba koja koristi parkiralište. Prilikom prvog dolaska se registruje, ima mogucnost uplate parkinga na određene vremenske periode te korištenja istog. 

**Majstor**
Osoba koja u slučaju kvara na sistemu dolazi te vrši potrebne popravke.

**Vlasnik**
Osoba koja ima pristup finansijskim izvještajima o poslovanju firme.

## **Uputstvo za koristenje**

**Pocetna stranica**

Na pocetnoj stranici korisnici aplikacije imaju mogucnost da se prijave da bi nastavili sa daljnim koristenjem iste. Takoder
postoji implementirana Help opcija koja korisniku olaksava koristenje aplikacije. Pored toga postoji i opcija "Dolasci" koja omogucava
dobar uvid u to koliko koji radnik provodi vremena na poslu i sprijecava mogucnost "varanja".

**Log in**

Nakon sto korisnik odabere opciju prijave na pocetnoj stranici potrebno je sada da unese svoje osnovne podatke i funkciju koju on izvrsava. Svako polje zahtijeva unos
ispravnih podataka. U slucaju da se zaboravi password potrebno je da se korisnik aplikacije javi vlasniku firme.

**Vlasnik**

Nakon logovanja ima ponudenu mogucnost uvida u dnevni,mjesecni i godisnji izvjestaj.

**Majstor**

Nakon prijave ima mogucnost popunjavanja izvjestaja koji sadrzi sve potrebne podatke vezane za kvar i popravku.

**Supervizor**

Nakon prijavljivanja supervizor ima ponudene tri mogucnost. Ima uvid u sve korisnike koji su koristili RFID uredaj. Takoder moze
izvrsiti prijavljivanje novog radnika kao i vratiti se na pocetnu stranicu.

**Korisnik**

Nakon logovanja ima mogucnost odabira vremenskog perioda za koji zeli uplatiti parking. Uz sve to je potreban broj kreditne kartice.
Takoder korisnik vidi i cjenovnik koji mu moze pomoci pri odabiru navedenih opcija.

**Dezurni radnik**

Dezurni radnik poziva majstora u slucaju kvara. Takoder on prijavljuje nove korisnike parkinga koji dolaze prvi put. Poziv majstora se
vrsi telefonskim pozivom.





-Eksterni uredjaj koji je koristen-RFID 
https://github.com/ooad-2015-2016/Minions/blob/master/ProjekatAutomaticCarParkingSystem/ProjekatAutomaticCarParkingSystem/FORME/FormaUnosDezurnogRadnika.xaml.cs

-Ispostovane validacije : 
https://github.com/ooad-2015-2016/Minions/blob/master/ProjekatAutomaticCarParkingSystem/ProjekatAutomaticCarParkingSystem/FORME/FormaUnosKorisnikavol2.xaml.cs

https://github.com/ooad-2015-2016/Minions/blob/master/ProjekatAutomaticCarParkingSystem/ProjekatAutomaticCarParkingSystem/FORME/FormaUnosDezurnogRadnika.xaml.cs

 

