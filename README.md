UI RPG Spēle

Spēles apraksts

Šī ir vienkārša RPG stila spēle ar cīņu starp spēlētāju un pretiniekiem, izmantojot UI slāni. 
Spēlētājs var izvēlēties ieroci, uzbrukt, aizsargāties ar vairogu, izmantot burvestības (dziedināšana un spēka palielināšana), kā arī iegūt pieredzi un paaugstināt līmeni.

Objektorientētās programmēšanas principu pielietojums

Mantošana
- Character ir bāzes klase.
- Player un Enemy manto Character.
- Berserker, Mage, Archer manto Enemy.
- Weapon ir abstrakta klase, kuru manto Sword, Spear, PoisonDagger, FireStaff, Longbow.

Enkapsulācija
- Iekapsulēti dati, piemēram, spēlētāja vārds (charName), veselība (health), aktīvais ierocis (activeweapon) ar getter.
- Setter funkcija SetWeapon() nodrošina drošu ieroča maiņu.

Polimorfisms
Override: Katrs Enemy apakštips (piemēram, Berserker) pārdefinē Attack() funkciju ar savu loģiku.
Overload: Character klasē GetHit(int) un GetHit(Weapon) – pārslodzes piemērs.

Abstrakcija
- Weapon ir abstrakta klase ar abstraktu metodi ApplyEffect() un parasto GetDamage().
- Dažādi ieroču tipi implementē dažādus efektus (Poison, Burn, Crit, u.c.).


Spēles funkcionalitāte

- Spēlētājs izvēlas ieroci pirms cīņas.
- Uzbrukumi un aizsardzība notiek pa soļiem.
- Pretinieki automātiski uzbrūk pēc spēlētāja gājiena.
- Vairogs samazina bojājumus, bet var salūzt.
- Spēlētājs saņem pieredzi par uzvaru un ceļ līmeni.
- Burvestības: spēlētājs var uz laiku palielināt uzbrukuma spēku vai atjaunot veselību.

Realizēts papilduzdevums

3 dažādi pretinieki ar atšķirīgiem uzbrukumiem (Berserker, Mage, Archer)
3 dažādi ieroči ar dažādiem efektiem (Sword, Spear, PoisonDagger, FireStaff, Longbow)
Līmeņu sistēma spēlētājam
Bruņu sistēma – efektivitāte atkarīga no ieroča tipa un bruņām
Burvestības – dziedināšana un uzbrukuma spēka palielināšana

Radoši papildinājumi

- Ieroču efekti pielāgoti spēles loģikai (indēšana, kritiskais trieciens u.c.).
- UI pielāgots spēlētāja izvēlēm (ieroču izvēle, vairoga ieslēgšana, burvestību pogas).
- Tīra klasiskā RPG struktūra.

Kā spēlēt

1. Izvēlies ieroci.
2. Spied Attack vai Shield On/Off.
3. Lieto Buff vai Heal pogas, lai uzvarētu pretiniekus.
4. Skaties savu līmeni un pieredzi UI paneļos.
