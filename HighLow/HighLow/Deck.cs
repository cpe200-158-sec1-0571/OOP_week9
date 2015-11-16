using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Deck 
    {
        public List<Cards> Cards;
        private static Random rand = new Random();
        private const int numberofcards = 52;
        


        public Deck()
        {
           
            Cards = new List<Cards>();

            for (int s = 1; s <= 4; s++)
            {
                for (int r = 1; r <= 13; r++)
                {
                    Cards.Add(new Cards(r,s));
                }
            }


        }

        

        public void Shuffle()
        {
           
            for (int i = 0; i < numberofcards; i++)
            {
                int k = rand.Next(numberofcards);
                Cards temp = Cards[i];
                Cards[i] = Cards[k];
                Cards[k] = temp;
            }
        }
        public Cards TakeCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);
            return card;
        }
       

    }
}
