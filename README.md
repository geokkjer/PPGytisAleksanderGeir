## Nissens liste og hans hjelpere
Denne appen skal brukes som starten på et oppslagsverk for å administrere Nissens hjelpere og barn på snille/slemme-listen.
Du skal lage en applikasjon som inneholder følgende:

## Baseklasse: 
Lag en baseklasse som heter Helper som beskriver grunnleggende egenskaper for Nissens hjelpere. Eksempler på egenskaper:
Kan hjelpe nissen
Har spesialisering (f.eks. bygge leker, pakke gaver)
Kan fly

## Avledede klasser: 
Lag spesifikke klasser for Nissens ulike hjelpere, som:
Elf (Kan bygge leker, har magiske evner, plage: kan være rampete)
Reindeer (Kan fly, trekker sleden, har rødt eller vanlig nese)
Snowman (Kan overvåke barn og rapportere til Nissen, kan smelte i varmt vær)
Santa (Kan levere gaver, har magisk sekk, kan spise for mye pepperkaker)
Barn på listen:
Lag en baseklasse Child som har egenskaper som: 
Navn
Oppførsel (Snill eller Slem)
Eventuelt ønskeliste, om de har fått gave, etc.
Implementer en liste over barn som enten er snille eller slemme, og gjør det mulig å administrere denne listen.

## Interface:
Lag et interface IMagical som definerer magiske egenskaper. F.eks.:
Utføre magi (metode PerformMagic())
La klasser som Elf, Santa og Reindeer implementere dette.

## Konsollmeny:
Når programmet starter, skal brukeren få følgende valg:
Se liste over hjelpere og barn
Legge inn nye hjelpere eller barn
