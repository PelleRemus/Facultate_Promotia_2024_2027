namespace MetodeIterative;

public class MetodaLuiHeron : MetodaAproximatiilorSuccesive
{
    public MetodaLuiHeron(decimal a, decimal epsilon)
        : base((decimal)Math.Sqrt((double)a), a, epsilon, x => 0.5M * (x + a / x), a)
    { }

    public static void Exemple()
    {
        decimal epsilon = 1e-4M;
        Afisare(2, epsilon);
        Afisare(3, epsilon);
        Afisare(5, epsilon);

        Afisare(0.5M, epsilon);
    }

    private static void Afisare(decimal a, decimal epsilon)
    {
        var metoda = new MetodaLuiHeron(a, epsilon);
        metoda.Rezolvare();
        Console.WriteLine($"Iteratii: {metoda.Iteratii}, x*: {metoda.x[metoda.Iteratii]}");
    }
}
