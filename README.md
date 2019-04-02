# Grupa3-CSharks
## Tema: SeekAndFind

#### Članovi tima:
  - Zerina Aščerija
  - Azra Balić
  - Muhamed Ramić
    
### Opis teme
    
  * SeekAndFind okuplja na jedno mjesto one koji traže radnu snagu uz obuku kandidata i one koji žele praksu. Ova 
    aplikacija aplikantima omogućava da brže i lakše pronađu praksu te da na jednom mjestu prikupe informacije o
    mjestima koja nude praksu od interesa, u poređenju sa tradicionalnim I konsekventnim pristupom koji uključuje 
    novinsko oglašavanje ili ured za zapošljavanje. Online zapošljavanje nudi veću kontrolu, praćenje i upravljanje 
    aktivnostima, kao i automatizirane i konkurentne procese. Pored toga, poslodavcima koji traže radnike daje prostor 
    za neograničen broj oglasa na koje se korisnici mogu prijaviti, bez potrebe za velikom količinom formalnosti koje 
    konvencionalni pristup podrazumijeva.  Ova aplikacija pomaže poslodavcima da naprave brži odabir kandidata i da 
    uspostave kontakt sa potencijalnim budućim radnicima kompanije, sa opcijom automatske eliminacije neprikladnih 
    kandidata. 
    
### Procesi
 	
 * Korisnik kreira profil. Prvo se odlučuje da li je aplikant ili poslodavac. Nakon toga unosi lične podatke. U slučaju
    da je korisnik poslodavac, onda unosi: ime kompanije, mail adresu, broj telefona, mjesto, adresu. Ukoliko je korisnik 
    aplikant, onda unosi: ime, prezime, mail adresu, broj telefona, stručnu spremu, zanimanje.
 	
 * Korisnici mogu ažurirati podatke na svom profilu.
 	
 * Korisnici imaju mogućnost da obrišu svoj profil.
 	
 * Poslodavci objavljuju oglase u kojima opišu praksu.
 	
 * Poslodavci imaju mogućnost da ažuriraju određene podatke u oglasu te također produže rok oglasa.
 	
 * Poslodavci imaju mogućnost da obrišu oglas.
 	
 * Poslodavci mogu vidjeti listu aplikanata koji su se odazvali na oglas u svakom trenutko od postavljanja oglasa
 	
 * Nakon što se okonča rok oglasa poslodavci biraju aplikante kojima će poslati obavijest za razgovor.
 	
 * Poslodavci u aplikaciji mogu tražiti aplikante po određenim specifikacijama, vidjeti njihove profile, 
    te uzeti njihove CV-ove.
 	
 * Aplikanti mogu tražiti oglase po određenim specifikacijama.
 	
 * Aplikanti apliciraju na oglase.
 	
 * Aplikanti imaju mogućnost da se odjave sa oglasa na koji su aplicirali.
 	
 * Aplikanti imaju mogućnost da upravljaju obavjestima koje dobiju.
 
### Funkcionalnosti
 * #### FUNKCIONALNI ZAHTJEVI
    MODULI:
    - Pogled aplikanata
    - Pogled poslodavaca

    APLIKANTI:
    - Pretraživanje oglasa uz mogućnost filtriranja izbora u skladu sa interesima, kvalifikacijama ili lokacijom
    - Apliciranje na željeni oglas I praćenje promjena vezanih za oglas
    - Pregled profila određenog poslodavca sa mogućnošću eventualnog upita 
    - Postavljajnje i ažuriranje CV-a 

    POSLODAVCI:
    - Mogućnost postavljanja, ažuriranja i uklanjanja oglasa 
    - Prikupljanje CV-a prijavljenih kandidata na oglas, I sortiranje istih po kriteriju obrazovanja, iskustva I sl
    - Pretraživanje kandidata od interesa neovisno od oglasa, I njihovo eventualno obavještavanje
    - Prihvatanje ili odbijanje aplikanata uz mogućnost obavještavanja o statusu aplikanta (potvrda za izabrane I 
      dogovor intervjua ili odbijenica sa razlozima za istu)
    - Zakazivanje intervjua ili testiranja

    NEREGISTRIRANI KORISNICI:
    - Pretraživanje oglasa I aplikanata uz limitiran pristup podacima
    - Mogućnost dijeljenja oglasa
    
  * #### NEFUNKCIONALNI ZAHTJEVI
    
    - POUZDANOST 
      
      Informacije u sistemu ne smiju biti zastarjele. Aktivnosti vremenski ograničene,  zbog postojanja okvira koji
      se unaprijed definiše I kojeg su sudionici dužni pridržavati se. Kada poslodavac postavi oglas, postoji rok za 
      prijave/odjave, kao I rok za objavještavanje aplikanata o njihovom statusu, čime se sprečava mogućnost da korisnik 
      bude prijavljen na neaktuelan oglas.

    - PRIJATELJSKI INTERFEJS
    
      Interakcije sa sistemom treba bit intuitvna I lagana za upotrebu kako aplikantima, tako I firmama, uz podršku za 
      status provođenih aktivnosti (uspješno/neuspješno), kao I obavještavanje o ograničenjima i pogreškama.

    - SIGURNOST I PRIVATNOST
     
      Sistem treba održavati profile kompanija I aplikanata uz restriktivan I kontroliran pristup njihovim podacima i aktivnostima.

### Akteri

- Poslodavci: lica koja postavljaju i ažuriraju oglase za praksu na svojim računima. Poslodavci biraju među oglašenim kandidatima 
  one koji zadovoljavaju kriterije i pozivaju ih na razgovor. Također postoji mogućnost da poslodavac pronađe kandidate bez da se 
  oni prijave na konkurs i da ih pozove. 
  
- Aplikanti: osobe koje traže mjesto na kojem će raditi praksu. Nakon što kreiraju profil pomoću kojeg dijele biografiju i CV,
  prijavljuju se na oglase da bi dobili radno mjesto, ili bivaju pozvani od strane nekog poslodavca bez prethodne prijave.
  
- Neregistrovani korisnici: lica koja su u mogućnosti pregledati oglase i kandidate, ali sa restriktivnim pristupom. 
