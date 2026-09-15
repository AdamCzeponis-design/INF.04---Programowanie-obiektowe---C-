int poziom = 2;

string nazwaRangi = poziom switch
{
    1 => "Początkujący",
    2 => "Zaawansowany",
    3 => "Ekspert",
    _ => "Nieznany poziom" // symbol '_' zastępuje 'default'
};

Console.WriteLine(nazwaRangi); // Wynik: Zaawansowany

