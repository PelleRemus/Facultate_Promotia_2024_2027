namespace SistemeNeliniare;

public class MetodaGaussSeidel : SistemNeliniar
{
    public MetodaGaussSeidel(decimal x0, decimal y0, decimal z0, decimal epsilon,
        Func<decimal[], decimal> F, Func<decimal[], decimal> G, Func<decimal[], decimal> H)
        : base(x0, y0, epsilon, F, G)
    {
        this.z0 = z0;
        this.H = H;
    }

    public static void Exemple()
    {
        // Exemple
    }

    public override void Rezolvare()
    {
        // Algoritm
    }
}
