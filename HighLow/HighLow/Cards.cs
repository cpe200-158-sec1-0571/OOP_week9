using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Cards :Game
    {
        private int rank;
        private int suit;

        public Cards(int rankin, int suitin)
        {
            rank = rankin;
            suit = suitin;
        }

        public int getRank()
        {
            return rank;
        }



        public string nameRank()
        {
            switch (rank)
            {
                case 1: return "Ace";
                case 11: return "Jack";
                case 12: return "Queen";
                case 13: return "King";
                default: return Convert.ToString(rank);
            }
        }

        public string nameSuit()
        {
            switch (suit)
            {
                case 1: return "-Clubs";
                case 2: return "-Diamonds";
                case 3: return "-Hearts";
                case 4: return "-Spades";
                default: return "";
            }
        }

    }
}
