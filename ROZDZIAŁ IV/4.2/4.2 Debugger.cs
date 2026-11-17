
        string[] owoce = { "jabłko", "banan", "gruszka" };
        Random rnd = new Random();

        // Próba losowania indeksu za pomocą Next
        int indeks = rnd.Next(0, 2);
        Console.WriteLine(owoce[indeks]);
