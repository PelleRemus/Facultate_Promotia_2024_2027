namespace Polinoame;

public abstract class Polinom
{
    public const int nrPuncte = 1000;
    public int n;
    public decimal[] x;
    public decimal[] y;
    public decimal[] u;
    public decimal[] f;
    public decimal[][] F;

     public Polinom(int n, decimal[] x, decimal[] y)
     {
         this.n = n;
         this.x = x;
         this.y = y;
         u = new decimal[nrPuncte];
         f = new decimal[nrPuncte];
         F = new decimal[n + 1][];
     }

     public abstract void CalcularePuncte();
}
