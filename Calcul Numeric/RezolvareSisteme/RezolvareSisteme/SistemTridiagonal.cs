namespace RezolvareSisteme
{
    public class SistemTridiagonal : Sistem
    {
        public decimal[] a;
        public decimal[] c;
        public decimal[] d;

        public SistemTridiagonal(int n, decimal[] a, decimal[] b, decimal[] c, decimal[] d, decimal[,] A)
            : base(n, A, b)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }

        public static void Exemple()
        {
            int n = 6;
            decimal[] a = { 1, 1, 1, 1, 1, 1 };
            decimal[] b = { 0, -0.125m, -0.125m, -0.125m, -0.125m, -0.25m };
            decimal[] c = { -0.25m, -0.125m, -0.125m, -0.125m, -0.125m, 0 };
            decimal[] d = { -10.5m, 7.25m, 8.6875m, -12.75m, 9.8125m, -6.5m };
            decimal[,] A = new decimal[n, n];

            var sistem = new SistemTridiagonal(n, a, b, c, d, A);
            sistem.Rezolvare();
            Console.WriteLine(sistem);
        }

        public override void Rezolvare()
        {
            decimal[] u = new decimal[n];
            u[0] = c[0] / a[0];

            decimal[] w = new decimal[n];
            for (int i = 1; i < n - 1; i++)
            {
                w[i] = a[i] - u[i - 1] * b[i];
                u[i] = c[i] / w[i];
            }
            w[n - 1] = a[n - 1] - u[n - 2] * b[n - 1];

            decimal[] z = new decimal[n];
            z[0] = d[0] / a[0];
            for (int i = 1; i < n; i++)
            {
                z[i] = (d[i] - b[i] * z[i - 1]) / w[i];
            }

            x[n - 1] = z[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                x[i] = z[i] - u[i] * x[i + 1];
            }
        }
    }
}
