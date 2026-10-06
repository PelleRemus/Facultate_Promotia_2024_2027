namespace RezolvareSisteme
{
    /// <summary>
    /// Prin metoda eliminarii a lui Gauss, un sistem oarecare poate deveni un sistem superior triangular. <br/>
    /// Acesta este mai apoi usor de rezolvat.
    /// </summary>
    public class MetodaGauss : SistemSuperiorTriunghiular
    {
        public MetodaGauss(int n, decimal[,] A, decimal[] b)
            : base(n, A, b)
        { }

        public static void Exemple()
        {
            int n = 3;
            var A = new decimal[,]
            {
                { 10, 2, -1 },
                { -3, 1, -5 },
                { -2, -5, 1 }
            };
            var b = new decimal[] { 9, -8, -1 };

            var sistem = new MetodaGauss(n, A, b);
            sistem.Rezolvare();
            Console.WriteLine(sistem);
        }

        public override void Rezolvare()
        {
            for (int k = 0; k < n - 1; k++)
            {
                if (A[k, k] == 0)
                {
                    throw new ArgumentException("Elementele de pe diagonala principala a matricei sistemului nu pot fi 0");
                }
                decimal p = A[k, k];

                for (int j = k; j < n; j++)
                {
                    A[k, j] /= p;
                }
                b[k] /= p;

                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        A[i, j] -= A[k, j] * A[i, k];
                    }
                    b[i] -= b[k] * A[i, k];
                }
            }
            base.Rezolvare();
        }
    }
}
