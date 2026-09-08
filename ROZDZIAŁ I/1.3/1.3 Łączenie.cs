string imie = "Anna";
int punkty = 50;
int bonus = 10;

// Konkatenacja za pomocą operatora +
string komunikat1 = "Gracz " + imie + " zdobył " + (punkty + bonus) + " punktów.";

// Uwaga na brak nawiasów przy konkatenacji!
string blednyWynik = "Wynik: " + punkty + bonus; // Wynik: 5010 (sklejanie tekstu!)
string poprawnyWynik = "Wynik: " + (punkty + bonus); // Wynik: 60 (dodawanie w nawiasie)

// Porównanie z interpolacją ($) – czytelniejszy zapis
string komunikat2 = $"Gracz {imie} zdobył {punkty + bonus} punktów.";

Console.WriteLine(komunikat1);
Console.WriteLine(blednyWynik);
Console.WriteLine(komunikat2);