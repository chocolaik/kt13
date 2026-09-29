using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt13
{
    struct Card
    {
        public Suit Suit;
        public Rank Rank;

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

}