string zdanie = "To jest przykładowe zdanie";

// Dzielimy tekst po znaku spacji ' '
string[] slowa = zdanie.Split(' ');

foreach (var slowo in slowa)
{
    Console.WriteLine(slowo); // Wypisuje każde słowo w nowej linii
}

