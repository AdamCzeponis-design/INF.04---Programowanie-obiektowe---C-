string tekst = "C# 2026";
char pierwszaLitera = "X";

foreach (char z in tekst)
{
    if (char.IsLetter(tekst))
    {
        char wielka = z.ToUpper();
        Console.WriteLine(wielka);
    }
}