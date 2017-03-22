# Hepek

## Parkomania

<p align="center">
  <img src ="https://github.com/ooad-2016-2017/Hepek/blob/master/logo.png"/>
</p>

### Clanovi tima:

	* Subašić Admir
	* Šubara Zlatko

### Opis teme
---

Potreba za mirovanjem vozila je neizbježan pratioc svih vidova saobracaja. Upravo zbog toga, 
kako kod turista tako i kod samih gradana vecih gradova, cesto se postavlja pitanje 
"Gdje sigurno parkirati vozilo?". 

Parkomania omogucava korisniku da sigurno i efikasno pronade slobodno parking mjesto. Korisnici
aplikacije dobijaju informacije o svim parkinzima na odabranoj lokaciji. To podrazumijeva da li postoji
slobodno parking mjesto, radno vrijeme, zatim cijenu kao i udaljenost parking mjesta od trenutne lokacije.

Korisnik bi time pored vremena uštedio i na gorivu. Takode bi smanjio bespotrebno nerviranje.

### Procesi

--- 

#### Registracija i prijava 

Korisnik sam bira da li želi da se registruje ili ne. Ukoliko se korsnik ne registruje, ima uvid u sva 
parking mjesta na odabranoj lokaciji, dok registrovani korisnik može rezervisati bilo koje slobodno parking
mjesto, pri čemu je rezervacija ogranicena, odnosno rezervacija vrijedi dvadeset minuta od trenutka rezervisanja.

Registracija se vrši upisom osnovnih podataka o korisniku (ime, prezime, email, lozinka), medutim korisnik ne može
pristupiti sopstvenom nalogu dok ne izvrši aktivaciju koja mu automatski stiže na email koji je naveo prilikom
registracije. Nakon toga, jednostavnim upisom email-a i odgovarajuce lozinke korisnik je prijavljen na sistem.

#### Odabir parking mjesta

Nakon što je pokrenuo sistem, korisniku se na karti prikazuju sva parking mjesta koja su mu na maksimalnoj udaljenosti
od 7km. Korisnik ima opciju odabira željene lokacije na kojoj ce se prikazati sva parking mjesta. Nakon što su parkinzi
izlistani, korisnik jednostavnim klikom na odgovarajuci parking dobija sve potrebne informacije o odabranom parkingu.

#### Pregled detaljnih informacija o odabranom parkingu

Nakon odabira parkinga, korisnik ima pregled o detaljima parkinga, kao što su: graficki prikaz parkinga sa realnim dimenzijama 
svih parking mjesta, kapacitet parkinga, broj slobodnih mjesta, 
radno vrijeme, cijena, i slicno.


#### Rezervacija parking mjesta

Nakon što je korisnik odabrao željeni parking i ukoliko je registrovan, odnosno prijavljen na sistem, ima opciju rezervisanja
parking mjesta. Jednostavnim klikom korisnik rezerviše parking mjesto.

#### GPS navođenje

Nakon odabira željenog parkinga, korisniku se na mobilnom uredaju prikazuje najkraća putanja do parking mjesta preko GPS uređaja.
Korisnik također može da odabere neku alternativnu putanju.

#### Modeliranje parkinga i ažuriranje

Gradski parking je dužan da modelira i grafički prikaže sve svoje parkinge onako kako zaista izgledaju, te da označi mjesta koja su rezervisana (zauzeta), slobodna te rezervisana za invalide.

#### Omogućavanje korištenja servisa sistema

Sistem Parkomania je SaaS, dakle korisnik ovog sistema neće brinuti o tehničkom održavanju sistema, 
budući da će sistem biti centralno hostan kod kreatora, gdje će samo kreatori imati pristup korištenoj tehnologiji.


### Funkcionalnosti

---

* Mogućnost prijave u sistem
* Pregled svih parking mjesta na karti na željenoj udaljenosti
* Pregled detaljnih informacija o odabranom parkingu (grafički prikaz parkinga sa realnim dimenzijama svih parking mjesta,kapacitet parkinga,broj slobodnih mjesta, i sl.)	
* Mogućnost GPS navođenja do parkinga(uz odabir željene rute)
* Mogućnost rezervacije parking mjesta(ukoliko je korisnik prijavljen) 
* Mogućnost modeliranja i ažuriranja svih parkinga od strane gradskih parkinga, odnosno njihovih vlasnika


### Akteri

---

* **Globalni administratori** su ujedno i kreatori aplikacije i njeni vlasnici, te imaju punu kontrolu nad aplikacijom i njenim održavanjem.
* **Korisnik usluga** je osoba koja ima mogućnost logina, odabira, rezervacije, i GPS navođenja do parking mjesta.
* **Gradski parking** - firma koja pruža sve relevantne podatke o svim parking mjestima na lokaciji koju odabere korisnik.



