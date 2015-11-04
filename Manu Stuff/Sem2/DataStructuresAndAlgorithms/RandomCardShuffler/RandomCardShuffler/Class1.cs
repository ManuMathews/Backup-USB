using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCardShuffler
{
    public enum CardSuits
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum CardRanks
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    public struct Card
    {
        public CardRanks CardRank;
        public CardSuits CardSuit;

        public override string ToString()
        {
            return CardRank + " of " + CardSuit;
        }
    }
}
