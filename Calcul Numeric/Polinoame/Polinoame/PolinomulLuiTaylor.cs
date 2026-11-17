namespace Polinoame;

public class PolinomulLuiTaylor : Polinom
{
    public PolinomulLuiTaylor(int n, decimal[] x, decimal[] y)
        : base(n, x, y)
    {
        f = y;
    }

    public override void CalcularePuncte()
    {
        // Algoritm
    }
}