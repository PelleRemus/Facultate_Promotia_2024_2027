namespace SistemeNeliniare;

public class MetodaNewton : SistemNeliniar
{
    protected Func<decimal[], decimal> f, g;
    protected Func<decimal[], decimal> dfx, dgx, dfy, dgy;

    public MetodaNewton(Func<decimal[], decimal> f, Func<decimal[], decimal> g,
        Func<decimal[], decimal> dfx, Func<decimal[], decimal> dgx,
        Func<decimal[], decimal> dfy, Func<decimal[], decimal> dgy,
        decimal epsilon, decimal x0,decimal y0)
        : base(x0, y0, epsilon, f, g)
    {
        this.f = f;
        this.g = g;
        this.dfx = dfx;
        this.dgx = dgx;
        this.dfy = dfy;
        this.dgy = dgy;
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
