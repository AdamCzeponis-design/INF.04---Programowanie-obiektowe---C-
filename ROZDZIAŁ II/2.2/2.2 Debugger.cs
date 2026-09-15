string rola = "admin";

// Część 1: Klasyczna instrukcja switch
switch (rola)
{
    case "admin":
        Console.WriteLine("Dostęp przyznany: Administrator");
    // Cel: Program ma wypisać rolę i przejść dalej

    case "user":
        Console.WriteLine("Dostęp przyznany: Użytkownik");
        break;
}

// Część 2: Wyrażenie switch (Switch Expression)
int poziomRangi = rola switch
{
    "admin" => 10,
    "user" => 1,
    default => 0
}

