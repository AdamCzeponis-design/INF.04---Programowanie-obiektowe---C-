
        double cena = 19.78;

        Console.WriteLine($"Standardowe zaokrąglenie (Math.Round): {Math.Round(cena)}");
        Console.WriteLine($"Zaokrąglenie w górę (Math.Ceiling): {Math.Ceiling(cena)}");
        Console.WriteLine($"Zaokrąglenie w dół (Math.Floor): {Math.Floor(cena)}");

        // Zaokrąglenie do 2 miejsc po przecinku
        double wynikDzielenia = 10.0 / 3.0; // 3.3333333333333335
        Console.WriteLine($"Wynik z dokładnością do 2 miejsc: {Math.Round(wynikDzielenia, 2)}");


