# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:**  
**Grupp:**  
**Datum:**  
**GitHub:**  

---

## Gruppmedlemmar

| Namn | Lämnade in |
|------|-----------|
| [Namn 1] | Zip + RAPPORT.md + REFLEKTION.md |
| [Namn 2] | REFLEKTION.md |
| [Namn 3] | REFLEKTION.md |

---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

Jag löste klass del genom att skapa två klasser, spelare och match. Varför jag gjorde det är för att i spelare sparar jag spelarens namnm, nummer samt position. Medan i match sparar jag lagen och datumet mathchen spelas.


### Metoderna

Jag skapade två metoder i Match. Presentera() visar vilken match det är och vilket datum den spelas. AnnounceraMålskytt() visar namnet, numret och positionen på spelaren som gjorde mål.


### Main()

Nör det kom till Main() så skapade jag två spelare och en match. Metoderna använde jag för att visa matchen och skriva ut båda målskyttarna.


### Git

Jag använde och jobbade i Git för att spara all arbete med commits i mellan. Jag skapade även en .giltignore som gör att bin/, obj/ och .vs/ inte följer med av git.


### Kodkvalitet

Jag försökte göra koden enkel och tydlig. Det vill säga att jag använde tydliga namn på klasser, variabler och metoder och delade upp koden så att Spelare och Match har olika uppgifter.


---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

> 

### Varför vi löste det såhär

> 

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
lazo@MacBook-Air-som-tillhor-Lazo-2 Drommatchen % git log --oneline
6e2e8de (HEAD -> main, origin/main, origin/HEAD) Uppdaterade gitignore
67fd1db la till .gitignore
4a2c87d la till program och main
ec1a275 la till properties samt constructor i matchen
6869392 la till matchklass
3a63771 jag la till konstruktor för Spelare
2a1210f Jag skapade spelare klassen, fält samt properties
34de7d5 refactor: gör property-kroppar tomma — studerande implementerar själva
66f4917 init: starterrepo för Drömmatchen (Inlämning 1)
```

