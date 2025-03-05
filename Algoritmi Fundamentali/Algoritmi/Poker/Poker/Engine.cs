using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public static class Engine
    {
        public static List<Card> cards = new List<Card>();
        public static Random random = new Random();
        public static int n = 52;
        public static int[] cardsOrder;

        public static void Initiaize()
        {
            //     Configuratii posibile:
            // one pair - acelasi numar apare de doua ori
            // two pairs - acelasi numar apare de doua ori, doua perechi
            // three of a kind - acelasi numar apare de trei ori
            // straight - in mana, apar cartile in ordine (culoarea nu conteaza)
            // flush - 5 carti de aceeasi culoare
            // full house - one pair + three of a kind
            // four of a kind - acelasi numar apare de 4 ori
            // straight flush - straight + flush
            cards.Add(new Card("../../Images/2OfClubs card.png"));
            cards.Add(new Card("../../Images/3OfClubs card.png"));
            cards.Add(new Card("../../Images/4OfClubs card.png"));
            cards.Add(new Card("../../Images/5OfClubs card.png"));
            cards.Add(new Card("../../Images/6OfClubs card.png"));
            cards.Add(new Card("../../Images/7OfClubs card.png"));
            cards.Add(new Card("../../Images/8OfClubs card.png"));
            cards.Add(new Card("../../Images/9OfClubs card.png"));
            cards.Add(new Card("../../Images/10OfClubs card.png"));
            cards.Add(new Card("../../Images/JackOfClubs card.png"));
            cards.Add(new Card("../../Images/QueenOfClubs card.png"));
            cards.Add(new Card("../../Images/KingOfClubs card.png"));
            cards.Add(new Card("../../Images/AceOfClubs card.png"));

            cards.Add(new Card("../../Images/2OfSpades card.png"));
            cards.Add(new Card("../../Images/3OfSpades card.png"));
            cards.Add(new Card("../../Images/4OfSpades card.png"));
            cards.Add(new Card("../../Images/5OfSpades card.png"));
            cards.Add(new Card("../../Images/6OfSpades card.png"));
            cards.Add(new Card("../../Images/7OfSpades card.png"));
            cards.Add(new Card("../../Images/8OfSpades card.png"));
            cards.Add(new Card("../../Images/9OfSpades card.png"));
            cards.Add(new Card("../../Images/10OfSpades card.png"));
            cards.Add(new Card("../../Images/JackOfSpades card.png"));
            cards.Add(new Card("../../Images/QueenOfSpades card.png"));
            cards.Add(new Card("../../Images/KingOfSpades card.png"));
            cards.Add(new Card("../../Images/AceOfSpades card.png"));

            cards.Add(new Card("../../Images/2OfHearts card.png"));
            cards.Add(new Card("../../Images/3OfHearts card.png"));
            cards.Add(new Card("../../Images/4OfHearts card.png"));
            cards.Add(new Card("../../Images/5OfHearts card.png"));
            cards.Add(new Card("../../Images/6OfHearts card.png"));
            cards.Add(new Card("../../Images/7OfHearts card.png"));
            cards.Add(new Card("../../Images/8OfHearts card.png"));
            cards.Add(new Card("../../Images/9OfHearts card.png"));
            cards.Add(new Card("../../Images/10OfHearts card.png"));
            cards.Add(new Card("../../Images/JackOfHearts card.png"));
            cards.Add(new Card("../../Images/QueenOfHearts card.png"));
            cards.Add(new Card("../../Images/KingOfHearts card.png"));
            cards.Add(new Card("../../Images/AceOfHearts card.png"));

            cards.Add(new Card("../../Images/2OfDiamonds card.png"));
            cards.Add(new Card("../../Images/3OfDiamonds card.png"));
            cards.Add(new Card("../../Images/4OfDiamonds card.png"));
            cards.Add(new Card("../../Images/5OfDiamonds card.png"));
            cards.Add(new Card("../../Images/6OfDiamonds card.png"));
            cards.Add(new Card("../../Images/7OfDiamonds card.png"));
            cards.Add(new Card("../../Images/8OfDiamonds card.png"));
            cards.Add(new Card("../../Images/9OfDiamonds card.png"));
            cards.Add(new Card("../../Images/10OfDiamonds card.png"));
            cards.Add(new Card("../../Images/JackOfDiamonds card.png"));
            cards.Add(new Card("../../Images/QueenOfDiamonds card.png"));
            cards.Add(new Card("../../Images/KingOfDiamonds card.png"));
            cards.Add(new Card("../../Images/AceOfDiamonds card.png"));

            cardsOrder = new int[n];
            for (int i = 0; i < n; i++)
                cardsOrder[i] = i;
        }

        public static void Shuffle()
        {
            for (int i = 1; i < n; i++)
            {
                int index = random.Next(i);
                Swap(i, index);
            }
        }

        public static void Swap(int i, int j)
        {
            int aux = cardsOrder[i];
            cardsOrder[i] = cardsOrder[j];
            cardsOrder[j] = aux;
        }

        public static async Task DealAllCards()
        {
            Shuffle();

            CardDealingAnimation(Form1.Instance.p1_1, cards[cardsOrder[0]].Image); await Task.Delay(200);
            CardDealingAnimation(Form1.Instance.p1_2, cards[cardsOrder[1]].Image); await Task.Delay(200);
            CardDealingAnimation(Form1.Instance.p1_3, cards[cardsOrder[2]].Image); await Task.Delay(200);
            CardDealingAnimation(Form1.Instance.p1_4, cards[cardsOrder[3]].Image); await Task.Delay(200);
            CardDealingAnimation(Form1.Instance.p1_5, cards[cardsOrder[4]].Image); await Task.Delay(200);

            CardDealingAnimation(Form1.Instance.p2_1, cards[cardsOrder[5]].Image); await Task.Delay(200);
            CardDealingAnimation(Form1.Instance.p2_2, cards[cardsOrder[6]].Image); await Task.Delay(200);
            CardDealingAnimation(Form1.Instance.p2_3, cards[cardsOrder[7]].Image); await Task.Delay(200);
            CardDealingAnimation(Form1.Instance.p2_4, cards[cardsOrder[8]].Image); await Task.Delay(200);
            CardDealingAnimation(Form1.Instance.p2_5, cards[cardsOrder[9]].Image); await Task.Delay(2000);
        }

        public static async void CardDealingAnimation(PictureBox destination, Image cardImage)
        {
            PictureBox card = Form1.Instance.CreatePictureBoxForNewCard();
            float percent = 30F / Distance(card.Location, destination.Location);

            for (int i = 1; i <= 100; i++)
            {
                await Task.Delay(i / 5);
                float x = card.Location.X + percent * (destination.Location.X - card.Location.X);
                float y = card.Location.Y + percent * (destination.Location.Y - card.Location.Y);
                card.Location = new Point((int)x, (int)y);
            }

            destination.BackgroundImage = cardImage;
            Form1.Instance.Controls.Remove(card);
            card.Dispose();
        }

        public static float Distance(Point p1, Point p2)
        {
            return (float)Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}