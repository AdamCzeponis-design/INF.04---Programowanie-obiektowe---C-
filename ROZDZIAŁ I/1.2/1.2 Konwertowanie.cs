Console.Write("Podaj rok swojego urodzenia: ");
string rokTekst = Console.ReadLine();

// Konwersja ze string na int
int rokUrodzenia = int.Parse(rokTekst);

// Skrócony zapis (często używany w praktyce):
// int rokUrodzenia = int.Parse(Console.ReadLine());

int wiek = 2026 - rokUrodzenia;
Console.WriteLine($"W tym roku kończysz {wiek} lat!");


