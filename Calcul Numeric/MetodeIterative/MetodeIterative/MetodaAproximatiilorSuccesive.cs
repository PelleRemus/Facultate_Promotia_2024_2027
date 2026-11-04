namespace MetodeIterative;

public class MetodaAproximatiilorSuccesive : MetodaNumerica
{
    public decimal x0;
    public Func<decimal, decimal> fi;

    public MetodaAproximatiilorSuccesive(decimal a, decimal b, decimal epsilon,
        Func<decimal, decimal> f, Func<decimal, decimal> fi, decimal x0)
        : base(f, a, b, epsilon)
    {
        this.fi = fi;
        this.x0 = x0;
        x.Add(x0);
    }

    public static void Exemple()
    {
        decimal a = 1, b = 2, x0 = 1, eps = 1e-4M;
        Func<decimal, decimal> fi = x => (decimal)Math.Pow((double)x + 1, 0.25);
        Afisare(a, b, eps, null, fi, x0);

        fi = x => (decimal)Math.Pow((double)x + 1, 1.0 / 3);
        Afisare(a, b, eps, null, fi, x0);

        a = 0; b = 0.5M; x0 = 0.5M;
        fi = x => 0.2M * (x * x * x * x * x + 1);
        Afisare(a, b, eps, null, fi, x0);

        a = (decimal)Math.PI / 4; b = (decimal)Math.PI / 2; x0 = 1.1781M;
        fi = x => (decimal)Math.Sin((double)x) + 0.25M;
        Afisare(a, b, eps, null, fi, x0);
    }

    public override void Rezolvare()
    {
        x.Add(fi(x[0]));
        Iteratii = 1;

        while (Math.Abs(x[Iteratii] - x[Iteratii - 1]) >= eps)
        {
            x.Add(fi(x[Iteratii]));
            Iteratii++;
        }
    }

    private static void Afisare(decimal a, decimal b, decimal epsilon,
        Func<decimal, decimal> f, Func<decimal, decimal> fi, decimal x0)
    {
        var metoda = new MetodaAproximatiilorSuccesive(a, b, epsilon, null, fi, x0);
        metoda.Rezolvare();
        Console.WriteLine($"Iteratii: {metoda.Iteratii}, x*: {metoda.x[metoda.Iteratii]}");
    }
}