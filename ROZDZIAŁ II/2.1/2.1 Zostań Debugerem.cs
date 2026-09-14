int zdobytePunkty = 85;
int maxPunkty = 100;

// Cel 1: Wylicz wynik procentowy (np. 85%)
double wynikProcentowy = zdobytePunkty / maxPunkty * 100;

// Cel 2: Przyznaj stypendium od 80% włącznie
if (wynikProcentowy >= 80) ;
{
    Console.WriteLine("Gratulacje! Przyznano stypendium.");
}
// Cel 3: Zaliczenie jest przyznawane od 50% włącznie
else if (wynikProcentowy > 50)
{
    Console.WriteLine("Egzamin zaliczony.");
}

