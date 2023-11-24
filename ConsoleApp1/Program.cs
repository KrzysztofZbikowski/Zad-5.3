class zad
{
    static void Przesun(ref double x, ref double y, double[] wek)
    {
        x = x + wek[0];
        y = y + wek[1];
    }
    static void Main(string[] args)
    {
        double[] wek = { 3, 2 };
        double x, y;
        Console.WriteLine("Podaj pierwszą współrzędną wektora: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą współrzędną wektora: ");
        y = double.Parse(Console.ReadLine());
        Przesun(ref x, ref y, wek);
        Console.WriteLine("Współrzędne twojego przesuniętego punktu: ({0},{1})", x, y);
    }
}