Primjer pristpnuh podataka za svaku od tri role:

Administrator
user:admin pass:admin

Uposlenik:
user:npulo1 pass:12345

Clan:
user:aburic1 pass:12345

1)
Potpuna perzistencija podataka je omoguæena povezivanjem sa OBP bazom. Komunikacija sa bazom radi na naèin da se pri pokretanju
aplikacije u odvojenom threadu otvori konekcija sa bazom i uèitaju svi podaci. Na kraju izvršavanja aplikacije
ponovo se otvori konekcija i svi podaci se spase. Ukoliko doðe do exceptiona pri konekciji
korisnik se obavijesti i aplikacija nastaivi offline modeu sa hardkodiranim vrijednostima. 
Sav kod za komunikaciju sa bazom se nalazi u klasi BazaPodataka.
U zipu je priložen i kod za kreiranje baze kao i ERD. 

2)
XML i Binarna serijalizacija i deserijalizacija su implementovane u administrator formi. GUI kod za serijalizaciju se nalazi
u klasi AdminForma a background kod u klasi Biblioteka.Serijalizacija.

3)
Animirani logo je kreiran uspomoæ Thread.Timera, za što se kod nalazi u klasi LoginForma. 
Serijalizacija i deserijalizacija se izvršavaju pomoæu taskova i async/await keyworda. Kod je u klasi AdminForma.
Komunikacija sa bazom pri uèitavanju i spašavanju se izvršava u odvojenom tasku. Kod je u LoginFormi(u konstruktoru i 
u FormClosing metodi). TPL biblioteka je iskorištena da bi se paralelizovale foreach petlje u metodama za analizu
(Biblioteka.Analiza, metode najcitanijiAutori() i najcitanijeKnjige())

4)
Napravljena je simplificirana verzija administratorske forme u UWP aplikaciji koja omoguæava kreiranje uposlenika i 
knjiga. 

Popravljeno u odnosu na prošlu zadaæu:
Dodani grafovi za analitièke funkciju(klasa Analiza, prikazuju se otvaranjem profila nekog uposlenika, otvaranjem taba
za analizu i pritiskom na odgovarajuæe dugme)

Nedostaci aplikacije:
Kreiranje novih èlanova/knjiga/uposlenika može nekada praviti probleme sa error provajderima. Objekat se 
ne može kreirati ako je neko polje pogrešno, ali se nekada error provajder može prikazati iako su svi
podaci ispravno uneseni(objekat æe se tada kreirati, ali æe error provajderi ipak prikazati). Ovo je problem 
u polju za unošenje isbn-a.



