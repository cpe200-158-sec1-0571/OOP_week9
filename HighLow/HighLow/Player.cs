using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Player : Game
    {
        public string player_name { get; set; }
        public int player_score { get; set; }
        public List<Cards> player_card = new List<Cards>();


        public Player(string n)
        {

            player_name = n;


        }

        public void HandCard(Deck d)
        {
            for (int j = 0; j < 26; j++)
            {
                var c1 = d.TakeCard();
                player_card.Add(c1);

            }

        }

        public void HandShuffle(int n)
        {
            Random rand = new Random();
            for (int i = n; i < 26; i++)
            {
                int x = rand.Next(n, 26);
                Cards c = player_card[i];
                player_card[i] = player_card[x];
                player_card[x] = c;
            }
        }
    }
}
