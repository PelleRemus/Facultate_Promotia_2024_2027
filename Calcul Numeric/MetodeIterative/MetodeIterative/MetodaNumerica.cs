namespace MetodeIterative;

public abstract class MetodaNumerica
{
    public Func<decimal, decimal> f;
    public decimal a, b;
    public decimal eps;
    public List<decimal> x;
    public int Iteratii;
    public MetodaNumerica(Func<decimal, decimal> f,
        decimal a, decimal b, decimal eps)
    {
        this.f = f;
        this.a = a;
        this.b = b;
        this.eps = eps;
        x = new List<decimal>();
        this.Iteratii = 0;
    }
    public abstract void Rezolvare();
}
