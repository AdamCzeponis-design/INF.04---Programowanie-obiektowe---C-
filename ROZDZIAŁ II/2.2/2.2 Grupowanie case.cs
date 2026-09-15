int numer = 1;
switch (numer) {
    // POPRAWNE (Grupowanie pustych etykiet):
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Dzień roboczy"); // Kod wykonuje się dla 1, 2, 3, 4 i 5
        break; 
}

// BŁĄD KOMPILACJI (Przejście z niepustego case):
//case 1:
    //Console.WriteLine("Poniedziałek"); // Jest instrukcja!
//case 2: // BŁĄD: C# wymaga break przed case 2, bo wyżej wykonano kod
    //Console.WriteLine("Wtorek");
    //break;


