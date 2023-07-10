using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauMau.core
{
    public class Deck: Cards
    {
        public const int NUMBER_OF_SUITS = 4;
        public const int NUMBER_OF_CARDS = 12;
        public const int NUMBER_OF_CARDS_MIN = 10;
        public const int MAX_NUMBER_OF_DECKS = 4;
        public const int MAX_NUMBER_OF_JOKERS_OF_DECKS = 2;

        public Deck(bool include89,int jokers,int numberOfDecks)
        {
            Includes89 = include89; 
            Jokers = jokers;    
            NumberOfDecks = numberOfDecks;
            this.checkInitValues();
            this.PopulateCards();            
        }

        private void checkInitValues()
        {
            if (this.NumberOfDecks < 1 || this.NumberOfDecks > MAX_NUMBER_OF_DECKS) throw new ArgumentException($"Number of Desks must be between 1 and {MAX_NUMBER_OF_DECKS}");
            if (this.Jokers < 0 || this.Jokers > this.NumberOfDecks*MAX_NUMBER_OF_JOKERS_OF_DECKS) throw new ArgumentException($"Number of Jokers must be between 0 and {MAX_NUMBER_OF_JOKERS_OF_DECKS} by number of decks");
        }

        public bool Includes89 { get; }
        public int Jokers { get; }

        public int NumberOfDecks { get; }   

        private void PopulateCards()
        {
            for (int i = 0; i < this.NumberOfDecks; i++)
            {
                this.AddJokers();
                this.AddSuitCards(eSuit.Golds);
                this.AddSuitCards(eSuit.Cups);
                this.AddSuitCards(eSuit.Swords);
                this.AddSuitCards(eSuit.Clubs);
            }

        }

        private void AddJokers() 
        {
            for (int j = 0; j < this.Jokers; j++)
            {
                this.Add(Card.CreateJoker());
            }
        }

        private void AddSuitCards(eSuit suit)
        {
            for(int i = 1; i <= 12; i++)
            {
                if (!this.Includes89 && (i == (int)eCardNumber.Eight || i== (int)eCardNumber.Nine)) continue;                
                this.Add(new Card(suit, (eCardNumber)i) );
            }
        }

    }
}
