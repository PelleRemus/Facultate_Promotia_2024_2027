namespace RezolvareSisteme
{
    public class MetodaGaussSeidel : MetodaJacobi
    {
        public MetodaGaussSeidel(int n, decimal[,] A, decimal[] b, decimal epsilon)
            : base(n, A, b, epsilon)
        { }

        // Nu ar trebui sa fie nevoie sa suprascriem "Rezolvare()", implementarea ar trebui sa fie la fel
        //public override void Rezolvare() { }

        protected override void CalculeazaSume(decimal[] s, int i)
        {
            // Formula diferita pentru calcularea sumelor
        }
    }
}
