namespace RezolvareSisteme
{
    public abstract class Sistem
    {
        public int n;
        public decimal[,] A;
        public decimal[] b;
        public decimal[] x;
        public Sistem(int n, decimal[,] A, decimal[] b)
        {
            this.n = n;
            this.A = A;
            this.b = b;
            x = new decimal[n];
        }
        public abstract void Rezolvare();
    }
}
