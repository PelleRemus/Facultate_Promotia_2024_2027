namespace MetodeIterative;

public class MetodaInjumatatiriiIntervalului : MetodaNumerica
{
    public MetodaInjumatatiriiIntervalului(Func<decimal, decimal> f,
        decimal a, decimal b, decimal eps)
        : base(f, a, b, eps)
    { }

    public static void Exemple()
    {
        Func<decimal, decimal> f = x => x * x * x - x + 1;
        decimal a = 0;
        decimal b = 1;
        decimal eps = 0.0001m;

        var metoda = new MetodaInjumatatiriiIntervalului(f, a, b, eps);
        metoda.Rezolvare();
        Console.WriteLine(metoda);
    }

    public override void Rezolvare()
    {
        // Algoritm
    }
}
