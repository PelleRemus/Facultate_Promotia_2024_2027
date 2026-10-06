namespace RezolvareSisteme
{
    // Matricea A a sistemului arata astfel:
    // a11 a12 a13 ... a1n
    // 0   a22 a23 ... a2n
    // 0   0   a33 ... a3n
    // ...
    // 0   0   0   ... ann
    public class SistemSuperiorTriunghiular : Sistem
    {
        public SistemSuperiorTriunghiular(int n, decimal[,] A, decimal[] b)
            : base(n, A, b)
        { }

        public static void Exemple()
        {
            var A = new decimal[,]
            {
                { 1, 2, 3 },
                { 0, -2, 4 },
                { 0, 0, 6 }
            };
            var b = new decimal[] { 5, 2, 3 };

            var sistem = new SistemSuperiorTriunghiular(3, A, b);
            sistem.Rezolvare();
            Console.WriteLine(sistem);
        }

        public override void Rezolvare()
        {
            x[n - 1] = b[n - 1] / A[n - 1, n - 1];
            for (int k = n - 2; k >= 0; k--)
            {
                decimal suma = 0;
                for (int i = k + 1; i < n; i++)
                {
                    suma += A[k, i] * x[i];
                }
                x[k] = (b[k] - suma) / A[k, k];
            }
        }

        public override string ToString()
        {
            string s = "X = { ";
            for (int i = 0; i < n; i++)
            {
                s += $"{x[i]}, ";
            }
            s = s.Substring(0, s.Length - 2) + " }";
            return s;
        }
    }
}
