int suma = 0;
int i = 0;

// Część 1: Pętla sumująca
while (i < 10)
{
    if (i % 2 == 0)
    {
        continue;
    }

    suma += i;
    i++;
}

// Część 2: Sprawdzenie wyniku
if (suma > 10)
{
    Console.WriteLine("Suma przekroczyła 10.");
    break;
}


