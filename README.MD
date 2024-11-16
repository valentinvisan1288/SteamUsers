SteamGame

[X]double price
[X]string genre
[X]int rating
[X] boolean isFinished

Steam users

[X]string userName
[X]int profileLevel
List <SteamGame> gameList
[X]GamerLevel GamerLevel -> enum (noob, intermediate, expert)
to read -> what does the keyword this means in c#

[X]De fixat GenreChecker

[]De citit despre constructorul explicit


[X]Constructor explicit pentru SteamGame

Cat Pufi = new Cat("Pufi", 4, 10);

[X]".this" gives access to all non-private members of the inherited class. Mixes properties from current and inherited class

[]De scris obiecte noi: caine, pisica
- picioare
- nume
- varsta
- setter + getter
- constructor
- instantiere

==19.09==

[X] Modifica numele clasei din SteamGames in Steamgame -> reflecta mai bine ceea ce facem (un obiect de tip steamgame, singular)
[X] Creaza mai multe obiecte (minim 3) de tip Steamgame cu pret, gen, rating diferite (cu cat mai diferite cu atat mai bine)

In clasa de metode ->
[X] Metoda care printeaza care Steamgame are pretul mai mare
[X] Metoda care imi aplica o reducere de 15% la pretul unui Steamgame si imi printeaza pretul
[X] Metoda care imi returneaza pretul total 

![ ] In clasa de Steamgame -> (hint: aici vreau sa apelez sub forma dota.increasePrice() spre exemplu)
[X] Metoda care scade pretul cu 10%
[X] Metoda care creste rating cu 1 daca este obiectul isFinished e true
[X] Metoda care creste ii dubleaza pretul

Bonus (putem face amandoi asta daca e prea mult, ai voie sa folosesti google):
[X] O lista noua (ArrayList sau List, vezi si tu cum e in c#) de SteamGame
[X]  Adauga in lista toate obiectele de mai sus.

=======21.09======================

[X] !!! Metoda care genereaza numele jocului in functie de instanta si il adauga ca si variabila (string) in obiect si apoi o printeaza -> Nu se poate captura numele instantei in C#

[X]  Metoda care itereaza lista si adauga la pret 10 (hint -> for each loop sau altceva)

[ ] de facut max manual - hint: un FOR care trece prin fiecare element (iterare)
si daca elementul curent este mai mare decat urmatorul element, atunci ii ia valuarea
// x = 0
// foreach steamGameList[x]
// x > y => x=y (?)

[X] TotalPrice sa foloseasca List

[x] Metoda care primeste ca parametru un obiect de tip SteamGame si un int X. Printeaza litera din genul jocului care corespunde lui X
[x] Metoda care primeste lista de obiecte steamGames si daca jocul are rating sub 6, le scoti din lista si returnezi lista
[X] metoda care primeste un obiect de tip SteamGames si imi returneaza pretul rotunjit de tip int

[x] Metoda care primeste genul unui joc si sa demonstram ca genul este sau nu palindrom (adauga un steamgame care are genul ca si palindrom ca sa testez corect)

[x] Folosete un IF intr-un FOREACH


[X] Rename Variables to be less confusing (ca si la "steamGameList")
[X] o metoda care primeste ca parametru o lista de steamgames in care verificam daca jocurile din lista au rating mai mare de 8 si daca sunt terminate, le punem intr-o alta lista 'MustPlay'. Daca nu, le punem in 'MaybePlay' (if - else if - else)
[x] ternary operator intr-un "if else" scris anterior

[x]o metoda care primeste o lista de steamgames si daca pretul este intre 1 si 10 atunci printam "jocul este foarte cheap".
restul de intervale din 10 in 10 eur. Fiecare caz are mesaj printat diferit

[X] O metoda care primeste ca parametru o lista de jocuri SteamGames si avem 4 intervale pentru pret. Fiecare interval adauga jocul intr-o lista. 4 intervale, 4 liste.



[X]C# For Loop
C# While si DoWhile
[X] Instante de SteamUsers


[X] Revizuieste Inheritance => fa un exemplu in Pisica / Animal, instantieri, de adaugat noi variabile
[X] Palindrom cu foreach
[9/10] 10 obiecte cu 10 constructori expliciti

[X] ce este Static la Methods
        - Inseamna ca metoda apartine CLASEI
          + Nu este o instanta a obiectului din clasa
        - Metoda este asociata cu clasa obiectului, nu cu instanta acestuia

[X] Create a C# program that calculates a student's grade from an integer. Ask the user for a number (x) and answer the following:

    10 - A+
    9 - A
    7,8 - B 
    6 - C
    5 - E
    0,4 - F
[x] Method Overloading + BOB
[x] Method Overwritting + BOB
[ ] Modificatori de acces
        - https://www.w3schools.com/cs/cs_access_modifiers.php
[ ] In GradeConvertor() -> add exception handling + BOB
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
[ ] de citit despre StringBuilder()