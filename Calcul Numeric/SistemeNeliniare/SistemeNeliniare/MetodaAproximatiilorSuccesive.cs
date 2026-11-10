namespace SistemeNeliniare;

public class MetodaAproximatiilorSuccesive : SistemNeliniar
{
    public MetodaAproximatiilorSuccesive(decimal x0, decimal y0, decimal epsilon,
        Func<decimal, decimal[]> F, Func<decimal, decimal[]> G)
        : base(x0, y0, epsilon, F, G)
    {}

    public static void Exemple()
    {
        // Exemple
    }

    public override void Rezolvare()
    {
        // Algoritm
    }
}
