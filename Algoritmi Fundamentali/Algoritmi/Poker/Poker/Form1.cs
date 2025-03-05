using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            pictureBox1.BackgroundImage = Image.FromFile("../../Images/BackCard.png");
            Engine.Initiaize();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            await Engine.DealAllCards();

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Selectam cartile pentru Player1
            int index = 0;
            Card[] cards = new Card[]
            {
                Engine.cards[Engine.cardsOrder[index]],
                Engine.cards[Engine.cardsOrder[index + 1]],
                Engine.cards[Engine.cardsOrder[index + 2]],
                Engine.cards[Engine.cardsOrder[index + 3]],
                Engine.cards[Engine.cardsOrder[index + 4]],
            };

            // Calculam scorul pentru Player1
            int player1Score = StraightFlush(cards);
            if (player1Score == -1) player1Score = FourOfAKind(cards);
            if (player1Score == -1) player1Score = FullHouse(cards);
            if (player1Score == -1) player1Score = Flush(cards);
            if (player1Score == -1) player1Score = Straight(cards);
            if (player1Score == -1) player1Score = ThreeOfAKind(cards);
            if (player1Score == -1) player1Score = TwoPairs(cards);
            if (player1Score == -1) player1Score = Pair(cards);
            if (player1Score == -1) player1Score = HighCard(cards);

            // Selectam cartile pentru Player2
            index = 5;
            cards[0] = Engine.cards[Engine.cardsOrder[index]];
            cards[1] = Engine.cards[Engine.cardsOrder[index + 1]];
            cards[2] = Engine.cards[Engine.cardsOrder[index + 2]];
            cards[3] = Engine.cards[Engine.cardsOrder[index + 3]];
            cards[4] = Engine.cards[Engine.cardsOrder[index + 4]];

            // Calculam scorul pentru Player2
            int player2Score = StraightFlush(cards);
            if (player2Score == -1) player2Score = FourOfAKind(cards);
            if (player2Score == -1) player2Score = FullHouse(cards);
            if (player2Score == -1) player2Score = Flush(cards);
            if (player2Score == -1) player2Score = Straight(cards);
            if (player2Score == -1) player2Score = ThreeOfAKind(cards);
            if (player2Score == -1) player2Score = TwoPairs(cards);
            if (player2Score == -1) player2Score = Pair(cards);
            if (player2Score == -1) player2Score = HighCard(cards);

            // Verificam cine a castigat
            if (player1Score > player2Score)
            {
                MessageBox.Show($"Player1: {player1Score}{Environment.NewLine}" +
                    $"Player2: {player2Score}", "Player1 has Won!");
            }
            else
            {
                MessageBox.Show($"Player1: {player1Score}{Environment.NewLine}" +
                    $"Player2: {player2Score}", "Player2 has Won!");
            }
        }

        private int HighCard(Card[] cards)
        {
            int max = cards[0].Number;

            for (int i = 1; i < cards.Length; i++)
            {
                if (cards[i].Number > max)
                {
                    max = cards[i].Number;
                }
            }

            return max;
        }

        private int Pair(Card[] cards)
        {
            int pairNumber = 0;

            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = i + 1; j < cards.Length; j++)
                {
                    if (cards[i].Number == cards[j].Number)
                    {
                        pairNumber = cards[i].Number;
                    }
                }
            }

            if (pairNumber != 0)
                return 100 + pairNumber;
            return -1;
        }

        private int TwoPairs(Card[] cards)
        {
            int pairNumber = Pair(cards);
            if (pairNumber == -1)
                return -1;
            else
                pairNumber = pairNumber - 100;

            int newPairNumber = -1;
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = i + 1; j < cards.Length; j++)
                {
                    if (cards[i].Number == cards[j].Number)
                    {
                        newPairNumber = cards[i].Number;
                        break;
                    }
                }
                if (newPairNumber != -1)
                    break;
            }

            if (newPairNumber != pairNumber)
                return 200 + Math.Max(newPairNumber, pairNumber);
            return -1;
        }

        private int ThreeOfAKind(Card[] cards)
        {
            int number = 0;

            for (int i = 0; i < cards.Length; i++)
                for (int j = i + 1; j < cards.Length; j++)
                {
                    for (int k = j + 1; k < cards.Length; k++)
                    {
                        if (cards[i].Number == cards[j].Number
                            && cards[i].Number == cards[k].Number)
                        {
                            number = cards[i].Number;
                        }
                    }
                }

            if (number != 0)
                return 300 + number;
            return -1;
        }

        private int Straight(Card[] cards)
        {
            // Sortare
            // Se poate si cu Array.Sort()
            //Array.Sort(cards, (Card a, Card b) =>
            //{
            //    return a.Number - b.Number;
            //});
            for (int j = 1; j < cards.Length; j++)
                for (int i = 0; i < j; i++)
                {
                    if (cards[i].Number > cards[j].Number)
                    {
                        Card temporar = cards[i];
                        cards[i] = cards[j];
                        cards[j] = temporar;
                    }
                }

            // Caz particular: As, 2, 3, 4, 5
            if (cards[4].Number == 14 && cards[0].Number == 2)
            {
                for (int i = cards.Length - 2; i >= 0; i--)
                {
                    cards[i + 1] = cards[i];
                }
                cards[0] = new Card(1);
            }

            // Verificarea daca e Straight
            for (int i = 0; i < cards.Length - 1; i++)
            {
                if (cards[i + 1].Number - cards[i].Number != 1)
                {
                    return -1;
                }
            }
            return 400 + cards[4].Number;
        }

        private int Flush(Card[] cards)
        {
            for (int i = 0; i < cards.Length - 1; i++)
            {
                if (cards[i].Suit != cards[i + 1].Suit)
                {
                    return -1;
                }
            }

            return 500 + HighCard(cards);
        }

        private int FullHouse(Card[] cards)
        {
            int number = ThreeOfAKind(cards);
            if (number == -1)
                return -1;
            else
                number = number - 300;

            Card differentCard = null;
            for (int i = 0; i < cards.Length; i++)
            {
                if (differentCard == null && cards[i].Number != number)
                {
                    differentCard = cards[i];
                }
                else if (cards[i].Number != number)
                {
                    if (differentCard.Number != cards[i].Number)
                        return -1;
                }
            }

            return 600 + HighCard(cards);
        }

        private int FourOfAKind(Card[] cards)
        {
            int number = 0;

            for (int i = 0; i < cards.Length; i++)
                for (int j = i + 1; j < cards.Length; j++)
                {
                    for (int k = j + 1; k < cards.Length; k++)
                        for (int l = k + 1; l < cards.Length; l++)
                        {
                            if (cards[i].Number == cards[j].Number
                                && cards[i].Number == cards[k].Number
                                && cards[i].Number == cards[l].Number)
                            {
                                number = cards[i].Number;
                            }
                        }
                }

            if (number != 0)
                return 700 + number;
            return -1;
        }

        private int StraightFlush(Card[] cards)
        {
            int number = Straight(cards);
            if (number == -1)
                return -1;

            if (Flush(cards) == -1)
                return -1;

            return 400 + number; // number e deja 400 + ceva
        }

        public PictureBox CreatePictureBoxForNewCard()
        {
            PictureBox card = new PictureBox();
            card.Parent = this;
            card.BackgroundImage = pictureBox1.BackgroundImage;
            card.Location = pictureBox1.Location;
            card.Size = pictureBox1.Size;
            card.BackgroundImageLayout = pictureBox1.BackgroundImageLayout;

            card.BringToFront();
            return card;
        }
    }
}