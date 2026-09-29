int a = 5;
int b = 10;
int wynik = ObliczPole(a, b);
Console.WriteLine($"Pole wynosi: {wynik}");
WyswietlKomunikat();
double poleDwa = ObliczPole("pięć", 10);
int ObliczPole(int szerokosc, int wysokosc)
{
    int pole = szerokosc * wysokosc;
}
void WyswietlKomunikat()
{
    Console.WriteLine("Obliczenia zakończone!");
    return "Gotowe";
}


