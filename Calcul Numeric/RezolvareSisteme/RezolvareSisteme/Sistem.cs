namespace RezolvareSisteme
{
    public abstract class Sistem
    {
        /// <summary>
        /// Numarul de ecuatii si de necunoscute ale sistemului.
        /// </summary>
        protected int n;

        /// <summary>
        /// Matricea A a sistemului. <br/>
        /// Reprezinta coeficientii necunoscutelor din sistem
        /// </summary>
        public decimal[,] A;

        /// <summary>
        /// Vectorul b al sistemului. <br/>
        /// Reprezinta rezultatele pentru fiecare ecuatie a sistemului.
        /// </summary>
        public decimal[] b;

        /// <summary>
        /// Vectorul x de necunoscute al sistemului.
        /// </summary>
        protected decimal[] x;

        public Sistem(int n, decimal[,] A, decimal[] b)
        {
            this.n = n;
            this.A = A;
            this.b = b;
            x = new decimal[n];
        }

        public abstract void Rezolvare();

        public override string ToString()
        {
            string s = "X = { ";
            for (int i = 0; i < n; i++)
            {
                s += $"{x[i]:0.######}, ";
            }
            s = s.Substring(0, s.Length - 2) + " }\n";
            return s;
        }
    }
}
