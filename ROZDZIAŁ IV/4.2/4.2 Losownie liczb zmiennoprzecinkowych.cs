
        Random rnd = new Random();

        // 1. Podstawowe losowanie z zakresu od 0.0 do 1.0
        double losowyUłamek = rnd.NextDouble();
        Console.WriteLine($"Losowa liczba (0.0 - 1.0): {losowyUłamek}");

        // 2. Skalowanie do własnego zakresu (np. od 10.0 do 50.0)
        // Wzór: rnd.NextDouble() * (max - min) + min
        double losowaCena = rnd.NextDouble() * (50.0 - 10.0) + 10.0;

        Console.WriteLine($"Wylosowana cena (10.0 - 50.0): {losowaCena}");


