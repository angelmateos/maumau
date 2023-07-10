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

        public override string ToString()
        {
            return string.Format("{0} of {1}", this.CardNumber, this.Suit);
        }
    }
}