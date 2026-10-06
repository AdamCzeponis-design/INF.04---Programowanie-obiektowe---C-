string tekst = "Programowanie w C# jest fajne!";
int liczbaLiter = 0;

// Pętla przechodzi po każdym znaku (char) w tekście
foreach (char znak in tekst)
{
    // Sprawdzamy, czy dany znak jest literą
    if (char.IsLetter(znak))
    {
        liczbaLiter++; // Zwiększamy licznik o 1
    }
}

Console.WriteLine($"Liczba liter: {liczbaLiter}");