using System.Net.Http.Headers;

namespace MauMau.core.Model
{
    public class Card
    {
        public eSuit Suit { get; }
        public eCardNumber CardNumber { get; }

        public Card(eSuit suit, eCardNumber cardNumber)
        {
            Suit = suit;
            CardNumber = cardNumber;
        }

        public static Card CreateJoker()
        {
            return new Card(eSuit.NoSuit, eCardNumber.Joker);
        }

        public string Id()
        {
            switch (Suit)
            {
                case eSuit.NoSuit:
                    return "JK";
                case eSuit.Cups:
                    return $"{(int)CardNumber}Cp";
                case eSuit.Golds:
                    return $"{(int)CardNumber}Gd";
                case eSuit.Swords:
                    return $"{(int)CardNumber}Sw";
                case eSuit.Clubs:
                    return $"{(int)CardNumber}Cb";
                default:
                    return string.Empty;
            }
        }

        public override string ToString()
        {
            string result = Suit == eSuit.NoSuit ? "Joker" : string.Format("{0} of {1}", CardNumber, Suit);
            return $"{result} ({Id()})";
        }
    }
}