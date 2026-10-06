string tekst = "Adam";

Console.WriteLine(tekst.Length);            // Wynik: 4 (właściwość - brak nawiasów!)
Console.WriteLine(tekst.ToUpper());         // Wynik: "ADAM"
Console.WriteLine(tekst.ToLower());         // Wynik: "adam"
Console.WriteLine(tekst.Contains("da"));    // Wynik: true
Console.WriteLine(tekst.StartsWith("A"));   // Wynik: true
Console.WriteLine(tekst.EndsWith("m"));     // Wynik: true


