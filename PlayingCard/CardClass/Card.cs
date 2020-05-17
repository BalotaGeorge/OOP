using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public enum CardRank
    {
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING,
        ACE
    }
    public enum CardSuit
    {
        SPADE,
        HEART,
        DIAMOND,
        CLUB
    }
    public class Card
    {
        public readonly CardRank Rank;
        public readonly CardSuit Suit;
        public Card(CardRank Rank, CardSuit Suit)
        {
            this.Rank = Rank;
            this.Suit = Suit;
        }
        public override string ToString()
        {
            return $"Card: {Rank} of {Suit}";
        }
    }
}
