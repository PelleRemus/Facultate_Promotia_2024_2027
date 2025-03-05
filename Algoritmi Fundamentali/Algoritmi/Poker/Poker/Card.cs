using System.Drawing;

namespace Poker
{
    public enum Suits
    {
        Clubs = 0,
        Spades,
        Hearts,
        Diamonds
    }

    public class Card
    {
        public Image Image { get; set; }
        public int Number { get; set; }
        public Suits Suit { get; set; }

        public Card(int number)
        {
            Number = number;
        }
        public Card(string path)
        {
            Image = Image.FromFile(path);
            Number = Engine.cards.Count % 13 + 2;
            Suit = (Suits)(Engine.cards.Count / 13);
        }
    }
}