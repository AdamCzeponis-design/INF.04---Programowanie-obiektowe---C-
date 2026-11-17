
        Random rnd = new Random();

        // A. Losowanie małej litery alfabetu ('a'-'z')
        char wylosowanaLitera = (char)rnd.Next(97, 123);
        Console.WriteLine($"Wylosowana litera: {wylosowanaLitera}");

        // B. Losowanie gotowego wyrazu z tablicy
        string[] wyrazy = { "programowanie", "komputer", "algorytm", "klasa", "zmienna" };

        // Length zwraca liczbę elementów; rnd.Next automatycznie wyklucza górną granicę
        int wylosowanyIndeks = rnd.Next(wyrazy.Length);
        string wylosowaneSlowo = wyrazy[wylosowanyIndeks];

        Console.WriteLine($"Wylosowane słowo z puli: {wylosowaneSlowo}");





