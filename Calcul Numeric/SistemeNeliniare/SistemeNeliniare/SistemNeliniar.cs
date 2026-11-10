namespace SistemeNeliniare;

public abstract class SistemNeliniar
{
    public int n;
    public decimal x0, y0, z0;
    public decimal xn, yn, zn;
    public decimal epsilon;
    // Pentru apelul fct F: F([x, y])
    public Func<decimal[], decimal> F;
    public Func<decimal[], decimal> G;
    public Func<decimal[], decimal> H;

    public SistemNeliniar(decimal x0, decimal y0, decimal epsilon,
        Func<decimal[], decimal> F, Func<decimal[], decimal> G)
    {
        this.x0 = x0;
        this.y0 = y0;
        this.epsilon = epsilon;
        this.F = F;
        this.G = G;
    }

    public abstract void Rezolvare();
}
