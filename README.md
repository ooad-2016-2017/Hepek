?![0xdeadc0de](https://github.com/ooad-2016-2017/Hepek/blob/master/logo.png)

# Hepek

## Parkomania

### Clanovi tima:

	* Subašic Admir
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
mjesto, pri cemu je rezervacija ogranicena, odnosno rezervacija vrijedi dvadeset minuta od trenutka rezervisanja.

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

#### GPS navodenje

Nakon odabira željenog parkinga, korisniku se na mobilnom uredaju prikazuje najkraca putanja do parking mjesta preko GPS uredaja.
Korisnik takode može da odabere neku alternativnu putanju.

#### Omogucavanje korištenja servisa sistema


Sistem Parkomania je SaaS, dakle korisnik ovog sistema nece brinuti o tehnickom održavanju sistema, 
buduci da ce sistem biti centralno hostan kod kreatora, gdje ce samo kreatori imati pristup korištenoj tehnologiji.



