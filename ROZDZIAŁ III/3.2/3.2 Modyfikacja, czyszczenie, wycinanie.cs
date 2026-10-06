string tekst = "Adam";

// Zamiana fragmentu
Console.WriteLine(tekst.Replace("Adam", "Piotr")); // Wynik: "Piotr"

// Wycinanie: zacznij od indeksu 1 ('d') i wytnij 2 znaki -> "da"
Console.WriteLine(tekst.Substring(1, 2)); // Wynik: "da"

// Czyszczenie spacji
string ktos = "  Adam   ";
Console.WriteLine(ktos.Trim()); // Wynik: "Adam"



