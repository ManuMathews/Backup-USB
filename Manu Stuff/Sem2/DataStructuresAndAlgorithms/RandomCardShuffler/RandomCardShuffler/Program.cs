using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCardShuffler
{
    class Program
    {

        static void Main(string[] args)
        {
            Card playingCard = new Card();
            string[] cards = new string[52];
            string[] shuffledCards = new string[52];
            int i = 0;


            










            foreach (CardSuits crdsut in Enum.GetValues(typeof(CardSuits)))
            {
                playingCard.CardSuit = crdsut;
                foreach (CardRanks crdrnk in Enum.GetValues(typeof(CardRanks)))
                {
                    

                    playingCard.CardRank = crdrnk;
                    cards[i] = playingCard.ToString();
                    Console.WriteLine(cards[i]);
                    i++;
                }
            }
            Console.WriteLine();

            //Shuffle cards here:

            shuffledCards = shuffler(cards);

            i = 0;
            while (i <= 51)
            {
                Console.WriteLine(shuffledCards[i]);
                i++;
            }


            //pick first five shuffled cards









            Console.ReadLine();

        }



        //**********Shuffle Cards Here**********
        static string[] shuffler(string[] array)
        {
            int a = 0;
            int b = 51;
            int r = 0;
            string cardNotLastOne;
            string cardLastOne;
            Random randomNumber = new Random();

            while (b >= 1)
            {
                r = randomNumber.Next(a, b);

                cardNotLastOne = array[r].ToString();
                cardLastOne = array[b];

                array[r] = cardLastOne;
                array[b] = cardNotLastOne;

                b--;
            }
            return array;
        }


        //***********************************************************************************
        //Things i might need later:


        //_______________________________________________________________________________________________________________
        //bool hearts = false; bool spades = false; bool diamonds = false; bool clubs = false;

        //bool ace = false; bool two = false; bool three = false; bool four = false; bool five = false; bool six = false;
        //bool seven = false; bool eight = false; bool nine = false; bool ten = false;
        //bool jack = false; bool queen = false; bool king = false;

        //if(crdsut == CardSuits.Hearts)
        //            {
        //                hearts = true;
        //            }

        //            if (crdsut == CardSuits.Spades)
        //            {
        //                spades = true;
        //            }

        //            if (crdsut == CardSuits.Diamonds)
        //            {
        //                diamonds = true;
        //            }

        //            if (crdsut == CardSuits.Clubs)
        //            {
        //                clubs = true;
        //            }

        //            //*****************************

        //            if (crdrnk == CardRanks.Ace)
        //            {
        //                ace = true;
        //            }

        //            if (crdrnk == CardRanks.Two)
        //            {
        //                two = true;
        //            }

        //            if (crdrnk == CardRanks.Three)
        //            {
        //                three = true;
        //            }

        //            if (crdrnk == CardRanks.Four)
        //            {
        //                four = true;
        //            }

        //            if (crdrnk == CardRanks.Five)
        //            {
        //                five = true;
        //            }

        //            if (crdrnk == CardRanks.Six)
        //            {
        //                six = true;
        //            }

        //            if (crdrnk == CardRanks.Seven)
        //            {
        //                seven = true;
        //            }

        //            if (crdrnk == CardRanks.Eight)
        //            {
        //                eight = true;
        //            }

        //            if (crdrnk == CardRanks.Nine)
        //            {
        //                nine = true;
        //            }

        //            if (crdrnk == CardRanks.Ten)
        //            {
        //                ten = true;
        //            }

        //            if (crdrnk == CardRanks.Jack)
        //            {
        //                jack = true;
        //            }

        //            if (crdrnk == CardRanks.Queen)
        //            {
        //                queen = true;
        //            }

        //            if (crdrnk == CardRanks.King)
        //            {
        //                king = true;
        //            }
        //_______________________________________________________________________________________________________________

    }

}

