string pin;

// Kod w bloku 'do' wykona się przynajmniej raz przed sprawdzeniem warunku
do
{
    Console.Write("Podaj poprawny PIN (1234): ");
    pin = Console.ReadLine();
}
while (pin != "1234"); // Pętla powtarza się, jeśli PIN jest BŁĘDNY

Console.WriteLine("Dostęp przyznany!");

