using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Game
    {
        public void checkWin(Player p1, Player p2)
        {
            if (p1.player_score > p2.player_score)
            {
                Console.WriteLine("\n !! {0} win !!", p1.player_name);
            }
            else if (p1.player_score < p2.player_score)
            {
                Console.WriteLine("\n !! {0} win !!", p2.player_name);
            }
            else
            {
                Console.WriteLine("\n !! No one lose !!");
            }
        }
        public void Start()
        {
            Deck deck = new Deck();
            deck.Shuffle();

            string n1, n2;
            Console.Write("Player1 name: ");
            n1 = Console.ReadLine();
            Player p1 = new Player(n1);
            Console.Write("Player2 name: ");
            n2 = Console.ReadLine();
            Player p2 = new Player(n2);


            int hold = 0; int checksame = 0;
            int countP1 = 0;
            int countP2 = 0;

            for (int i = 0; i < 26; i++)
            {

                Console.WriteLine("\n Compare Card {0}\n", i + 1);

                Console.Write("{0} Card: ", p1.player_name);
                p1.HandCard(deck);
                Console.WriteLine(p1.player_card.ElementAt(i).nameRank() +""+ p1.player_card.ElementAt(i).nameSuit());

                Console.Write("{0} Card: ", p2.player_name);
                p2.HandCard(deck);
                Console.WriteLine(p2.player_card.ElementAt(i).nameRank() + "" + p2.player_card.ElementAt(i).nameSuit());

                if (p1.player_card.ElementAt(i).getRank() < p2.player_card.ElementAt(i).getRank())
                {
                    if (hold == 0)
                    {
                        countP1 += 2;
                    }
                    else
                    {
                        countP1 = countP1 + hold;
                    }


                    Console.WriteLine("\n !!{0} win!!\n", p1.player_name);
                    Console.WriteLine("{0} score: {1} | {2} score: {3}", p1.player_name, countP1, p2.player_name, countP2);
                    Console.WriteLine("-----------------------\n");
                    hold = 0;
                    checksame = 0;


                }
                else if (p1.player_card.ElementAt(i).getRank() > p2.player_card.ElementAt(i).getRank())
                {
                    if (hold == 0)
                    {
                        countP2 += 2;
                    }
                    else
                    {
                        countP2 = countP2 + hold;
                    }

                    Console.WriteLine("\n !!{0} win!!\n", n2);
                    Console.WriteLine("{0} score: {1} | {2} score: {3}", p1.player_name, countP1, p2.player_name, countP2);
                    Console.WriteLine("-----------------------\n");
                    hold = 0;
                    checksame = 0;

                }

                else
                {
                    if (checksame == 0)
                    {
                        hold = (1 + Convert.ToInt16(p1.player_card.ElementAt(i).getRank())) * 2;
                        i = i + ((hold / 2) - 2);
                        if (i > 25)
                        {
                            i = 24;
                            hold = 52 - (countP1 + countP2);

                        }
                        checksame = 1;
                    }
                    else if (p1.player_card.ElementAt(i) == p2.player_card.ElementAt(i) && checksame == 1)
                    {
                        i = i - ((hold / 2) - 2);
                        hold = 0;
                        p1.HandShuffle(i);
                        p2.HandShuffle(i);
                        checksame = 0;
                        if (i > 25)
                        {
                            i = 24;
                            hold = 52 - (countP1 + countP2);

                        }
                        checksame = 0;
                    }


                    Console.WriteLine("\n !!No one win!!\n");
                    Console.WriteLine("{0} score: {1} | {2} score: {3}", n1, countP1, n2, countP2);
                    Console.WriteLine("hold = +{0}", hold);
                    Console.WriteLine("-----------------------\n");


                }
            }

            Console.WriteLine("\n--- R e s u l t --");
            Console.WriteLine("{0} score: {1}", n1, countP1);
            Console.WriteLine("{0} score: {1}", n2, countP2);

            p1.player_score = countP1;
            p2.player_score = countP2;

            checkWin(p1, p2);

        }
    }
}
