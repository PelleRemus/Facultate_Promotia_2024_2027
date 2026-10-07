namespace RezolvareSisteme
{
    /// <summary>
    /// Matricea A a sistemului arata astfel: <br/>
    /// a11 0   0   ... 0 <br/>
    /// a21 a22 0   ... 0 <br/>
    /// a31 a32 a33 ... 0 <br/>
    /// ... ... ... ... ... <br/>
    /// an1 an2 an3 ... ann <br/>
    /// </summary>
    public class SistemInferiorTriunghiular : Sistem
    {
        public SistemInferiorTriunghiular(int n, decimal[,] A, decimal[] b)
            : base(n, A, b)
        { }

        public static void Exemple()
        {
            int n = 3;
            var A = new decimal[,]
            {
                { 1, 0, 0 },
                { 2, 3, 0 },
                { 4, -1, 6 }
            };
            var b = new decimal[] { 2, 4, 1 };

            var sistem = new SistemInferiorTriunghiular(n, A, b);
            sistem.Rezolvare();
            Console.WriteLine(sistem);
        }

        public override void Rezolvare()
        {
            x[0] = b[0] / A[0, 0];
            for (int k = 1; k < n; k++)
            {
                decimal s = 0;
                for (int i = 0; i <= k - 1; i++)
                {
                    s += A[k, i] * x[i];
                }
                x[k] = (b[k] - s) / A[k, k];
            }
        }
    }
}
