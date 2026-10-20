namespace MetodeIterative;

public class MetodaCoardei : MetodaNumerica
{
    public decimal dda, ddb;
    public MetodaCoardei(Func<decimal, decimal> f, decimal a,
        decimal b, decimal eps, decimal dda, decimal ddb)
        : base(f, a, b, eps)
    {
        this.dda = dda;
        this.ddb = ddb;
    }

    public static void Exemple()
    {
        Func<decimal, decimal> f = x => x * x * x - 3 * x + 1;
        decimal a = 0;
        decimal b = 1;
        decimal eps = 0.0001m;
        decimal dda = 0, ddb = 6;

        var metoda = new MetodaCoardei(f, a, b, eps, dda, ddb);
        metoda.Rezolvare();
        Console.WriteLine(metoda);
    }

    public override void Rezolvare()
    {
        // Algoritm
    }
}
