// Szukamy pierwszej liczby podzielnej przez 7 w przedziale od 1 do 50
for (int i = 1; i <= 50; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"Znaleziono pierwszą liczbę podzielną przez 7: {i}");
        break; // Kończymy całą pętlę - nie sprawdzamy liczb od 8 do 50
    }

    Console.WriteLine($"Sprawdzam liczbę: {i}");
}

Console.WriteLine("Koniec przeszukiwania.");

