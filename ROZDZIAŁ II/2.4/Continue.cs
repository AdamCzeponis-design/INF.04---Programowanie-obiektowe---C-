// Wypisujemy liczby od 1 do 10, ale pomijamy liczby parzyste
for (int i = 1; i <= 10; i++)
{
    // Jeśli liczba jest parzysta, przeskakujemy do następnego obrotu
    if (i % 2 == 0)
    {
        continue; // Kod poniżej nie wykona się dla liczb parzystych
    }

    Console.WriteLine($"Liczba nieparzysta: {i}");
}