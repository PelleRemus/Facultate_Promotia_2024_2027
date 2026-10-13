namespace RezolvareSisteme
{
    public class MetodaJacobi : Sistem
    {
        /// <summary>
        /// <b>ε</b><br/>
        /// Eroarea admisa la aproximare.<br/>
        /// Are valori foarte mici, de exemplu 1e-10 (adica 0.0000000001).
        /// </summary>
        private decimal epsilon;

        /// <summary>
        /// Pasul ce urmeaza sa fie incrementat in timpul executarii algoritmului.
        /// </summary>
        protected int k;

        /// <summary>
        /// Istoricul valorilor sirului x 
        /// </summary>
        protected List<decimal[]> X;

        public MetodaJacobi(int n, decimal[,] A, decimal[] b, decimal epsilon)
            : base(n, A, b)
        {
            this.epsilon = epsilon;
            X = new List<decimal[]>();
        }

        public override void Rezolvare()
        {
            // Algoritm
        }

        // Aceasta formula este folosita ca parte a rezolvarii metodei Jacobi.
        // O scriem separat ca metoda virtuala, deoarece este singura diferenta
        // dintre metoda Jacobi si metoda Gauss-Seidel, si pentru acea metoda,
        // putem doar suprascrie modul in care calculam sumele, "Reolvare()" fiind neschimbata.
        protected virtual void CalculeazaSume(decimal[] s, int i)
        {
            for (int j = 0; j < n; j++)
            {
                if (j != i)
                {
                    s[i] = s[i] + A[i, j] * X[k - 1][j];
                }
            }
        }
    }
}