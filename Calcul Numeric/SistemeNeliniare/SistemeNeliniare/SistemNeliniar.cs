namespace SistemeNeliniare;

public abstract class SistemNeliniar
{
    public int n;
    public decimal x0, y0, z0;
    public decimal xn, yn, zn;
    public decimal epsilon;
    // Pentru apelul functilor, Ex: F([x, y]); G([x, y, z]);
    // Motivul pentru vector de decimal ca si input este lungimea variabila de parametri (2 sau 3 in cazul nostru)
    // Pentru a-l defini pe F, vom spune de exemplu x => <...>, iar pentru a-l folosi pe y in interiorul functiei f,
    // vom scrie x[1] in schimb. Indicele 0 il reprezinta pe x, iar indicele 2 il reprezinta pe z
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
