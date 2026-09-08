int a = 10;
int b = 4;

int suma = a + b;           // 14
int iloczyn = a * b;        // 40
int dzielenieInt = a / b;   // 2 (część ułamkowa została odrzucona!)
int reszta = a % b;         // 2 (bo 10 = 2 * 4 + 2 reszty)

// Dzielenie z ułamkiem - wymuszamy typ double
double dzielenieDouble = (double)a / b; // 2.5

Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Dzielenie int: {dzielenieInt}");
Console.WriteLine($"Reszta z dzielenia (modulo): {reszta}");
Console.WriteLine($"Dzielenie double: {dzielenieDouble}");