Console.Write("Podaj swój wiek: ");
int wiek = int.Parse(Console.ReadLine());

bool jestStudentem = true; // Zmienna logiczna przechowująca true/false

// Sprawdzamy warunki za pomocą operatorów porównania i logicznych
bool jestPelnoletni = wiek >= 18;
bool maZnizkeBiletUlgowy = (wiek < 26) && jestStudentem; // Wiek poniżej 26 I status studenta
bool darmowyWstep = (wiek < 7) || (wiek >= 65);         // Wiek poniżej 7 LUB od 65 lat

Console.WriteLine($"Czy osoba jest pełnoletnia: {jestPelnoletni}");
Console.WriteLine($"Czy przysługuje bilet ulgowy: {maZnizkeBiletUlgowy}");
Console.WriteLine($"Czy przysługuje darmowy wstęp: {darmowyWstep}");