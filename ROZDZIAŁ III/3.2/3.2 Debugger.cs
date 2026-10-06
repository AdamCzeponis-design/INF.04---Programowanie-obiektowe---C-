string imie = "  Jan Kowalski  ";

int iloscZnakow = imie.Length();

imie.Trim();

string inicjaly = imie.Substring(0, 50);

Console.WriteLine($"Oczyszczony tekst: {imie}, długość: {iloscZnakow}");

