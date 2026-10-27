namespace MetodeIterative;

public class MetodaModificataATangentei : MetodaTangentei
{
    public MetodaModificataATangentei(decimal a, decimal b,
        decimal epsilon, Func<decimal, decimal> f, decimal dfx0,
        decimal ddfa) : base(f, a, b, epsilon, x => dfx0, ddfa)
    { }
}

