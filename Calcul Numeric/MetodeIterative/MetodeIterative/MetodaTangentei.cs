
namespace MetodeIterative;

public class MetodaTangentei : MetodaNumerica
{
    private Func<decimal, decimal> df;
    private decimal ddfa;

    public MetodaTangentei(Func<decimal, decimal> f, decimal a,
        decimal b, decimal eps, Func<decimal, decimal> df, decimal ddfa)
        : base(f, a, b, eps)
    {
        this.df = df;
        this.ddfa = ddfa;
    }

    public override void Rezolvare()
    {
        // Algoritm
    }
}
