namespace MetodeIterative;

public class MT_Radical : MetodaTangentei
{
    private int m;
    private decimal c;
    public MT_Radical(decimal eps, int m, decimal c)
        : base(a: (c > 1 ? 1 : 0), b: c, eps: eps,
            f: x => (decimal)Math.Pow((double)x, m) - c,
            df: x => m * (decimal)Math.Pow((double)x, m - 1),
            ddfa: (c > 1 ? m * (m - 1) : 0))
    {
        this.m = m;
        this.c = c;
    }
}
