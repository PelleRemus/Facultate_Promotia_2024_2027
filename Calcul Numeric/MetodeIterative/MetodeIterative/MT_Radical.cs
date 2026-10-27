namespace MetodeIterative;

public class MT_Radical : MetodaTangentei
{
    private int k;
    private decimal c;
    public MT_Radical(decimal eps, int k, decimal c)
        : base(a: (c > 1 ? 1 : 0), b: Math.Max(1, c), eps: eps,
            f: x => (decimal)Math.Pow((double)x, k) - c,
            df: x => k * (decimal)Math.Pow((double)x, k - 1),
            ddfa: (c > 1 ? k * (k - 1) : 0))
    {
        this.k = k;
        this.c = c;
    }
}
