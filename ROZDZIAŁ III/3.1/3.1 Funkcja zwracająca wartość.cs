
int wynik = PobierzLiczbeLosowa();
Console.WriteLine($"Wylosowano liczbę: {PobierzLiczbeLosowa()}");
int PobierzLiczbeLosowa()
{
    Random rand = new Random();
    int wylosowana = rand.Next(1, 101);

    return wylosowana; // Zwracamy wartość typu int
}

