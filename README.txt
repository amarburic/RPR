Primjer pristpnuh podataka za svaku od tri role:

Administrator
user:admin pass:admin

Uposlenik:
user:npulo1 pass:12345

Clan:
user:aburic1 pass:12345

1)
Potpuna perzistencija podataka je omogu�ena povezivanjem sa OBP bazom. Komunikacija sa bazom radi na na�in da se pri pokretanju
aplikacije u odvojenom threadu otvori konekcija sa bazom i u�itaju svi podaci. Na kraju izvr�avanja aplikacije
ponovo se otvori konekcija i svi podaci se spase. Ukoliko do�e do exceptiona pri konekciji
korisnik se obavijesti i aplikacija nastaivi offline modeu sa hardkodiranim vrijednostima. 
Sav kod za komunikaciju sa bazom se nalazi u klasi BazaPodataka.
U zipu je prilo�en i kod za kreiranje baze kao i ERD. 

2)
XML i Binarna serijalizacija i deserijalizacija su implementovane u administrator formi. GUI kod za serijalizaciju se nalazi
u klasi AdminForma a background kod u klasi Biblioteka.Serijalizacija.

3)
Animirani logo je kreiran uspomo� Thread.Timera, za �to se kod nalazi u klasi LoginForma. 
Serijalizacija i deserijalizacija se izvr�avaju pomo�u taskova i async/await keyworda. Kod je u klasi AdminForma.
Komunikacija sa bazom pri u�itavanju i spa�avanju se izvr�ava u odvojenom tasku. Kod je u LoginFormi(u konstruktoru i 
u FormClosing metodi). TPL biblioteka je iskori�tena da bi se paralelizovale foreach petlje u metodama za analizu
(Biblioteka.Analiza, metode najcitanijiAutori() i najcitanijeKnjige())

4)
Napravljena je simplificirana verzija administratorske forme u UWP aplikaciji koja omogu�ava kreiranje uposlenika i 
knjiga. 

Popravljeno u odnosu na pro�lu zada�u:
Dodani grafovi za analiti�ke funkciju(klasa Analiza, prikazuju se otvaranjem profila nekog uposlenika, otvaranjem taba
za analizu i pritiskom na odgovaraju�e dugme)

Nedostaci aplikacije:
Kreiranje novih �lanova/knjiga/uposlenika mo�e nekada praviti probleme sa error provajderima. Objekat se 
ne mo�e kreirati ako je neko polje pogre�no, ali se nekada error provajder mo�e prikazati iako su svi
podaci ispravno uneseni(objekat �e se tada kreirati, ali �e error provajderi ipak prikazati). Ovo je problem 
u polju za uno�enje isbn-a.



