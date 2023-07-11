using System.Net.Http.Headers;

namespace MauMau.core
{
    public class Card
    {
        public eSuit Suit;
        public eCardNumber CardNumber;

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
            switch (this.Suit)
            {
                case eSuit.NoSuit:
                    return "JK";
                case eSuit.Cups:
                    return $"{(int)this.CardNumber}Cp";
                case eSuit.Golds:
                    return $"{(int)this.CardNumber}Gd";
                case eSuit.Swords:
                    return $"{(int)this.CardNumber}Sw";
                case eSuit.Clubs:
                    return $"{(int)this.CardNumber}Cb";
                default:
                    return string.Empty;
            }
        }

        public override string ToString()
        {
            string result = (this.Suit == eSuit.NoSuit) ? "Joker" : string.Format("{0} of {1}", this.CardNumber, this.Suit);
            return $"{result} ({this.Id()})";
        }
    }
}