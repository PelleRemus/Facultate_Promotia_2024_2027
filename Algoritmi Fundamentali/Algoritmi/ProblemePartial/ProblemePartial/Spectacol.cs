namespace ProblemePartial
{
    public class Spectacol : IComparable<Spectacol> // interfata optionala, pentru Sort
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Spectacol(string text)
        {
            string[] split = text.Split(' ');
            Start = int.Parse(split[0]);
            End = int.Parse(split[1]);
        }

        // Optional: pentru metoda "Sort()"
        public int CompareTo(Spectacol? other)
        {
            return End - other.End;
        }
    }
}
