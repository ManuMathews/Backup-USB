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
            Card[] cards = new Card[52];
            Card[] shuffledCards = new Card[52];
            int i = 0;

            Card[] cardValue1 = new Card[4];
            Card[] cardValue2 = new Card[4];








            foreach (CardSuits crdsut in Enum.GetValues(typeof(CardSuits)))
            {
                playingCard.CardSuit = crdsut;
                foreach (CardRanks crdrnk in Enum.GetValues(typeof(CardRanks)))
                {


                    playingCard.CardRank = crdrnk;
                    cards[i] = playingCard;
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


            //pick first five shuffled cards for first deck
            cardValue1[0].CardRank = shuffledCards[0].CardRank;     cardValue1[0].CardSuit = shuffledCards[0].CardSuit;
            cardValue1[1].CardRank = shuffledCards[1].CardRank;     cardValue1[1].CardSuit = shuffledCards[1].CardSuit;
            cardValue1[2].CardRank = shuffledCards[2].CardRank;     cardValue1[2].CardSuit = shuffledCards[2].CardSuit;
            cardValue1[3].CardRank = shuffledCards[3].CardRank;     cardValue1[3].CardSuit = shuffledCards[3].CardSuit;
            cardValue1[4].CardRank = shuffledCards[4].CardRank;     cardValue1[4].CardSuit = shuffledCards[4].CardSuit;

            //pick second five shuffled cards for second deck
            cardValue2[0].CardRank = shuffledCards[5].CardRank;     cardValue2[0].CardSuit = shuffledCards[5].CardSuit;
            cardValue2[1].CardRank = shuffledCards[6].CardRank;     cardValue2[1].CardSuit = shuffledCards[6].CardSuit;
            cardValue2[2].CardRank = shuffledCards[7].CardRank;     cardValue2[2].CardSuit = shuffledCards[7].CardSuit;
            cardValue2[3].CardRank = shuffledCards[8].CardRank;     cardValue2[3].CardSuit = shuffledCards[8].CardSuit;
            cardValue2[4].CardRank = shuffledCards[9].CardRank;     cardValue2[4].CardSuit = shuffledCards[9].CardSuit;
            
            int numberOfAcesInOne = 0;
            int numberOfTwosInOne = 0;
            int numberOfThreesInOne = 0;
            int numberOfFoursInOne = 0;
            int numberOfFivesInOne = 0;
            int numberOfSixesInOne = 0;
            int numberOfSevensInOne = 0;
            int numberOfEightsInOne = 0;
            int numberOfNinesInOne = 0;
            int numberOfTensInOne = 0;
            int numberOfJacksInOne = 0;
            int numberOfQueensInOne = 0;
            int numberOfKingssInOne = 0;
            
            //Checking first deck for same rank cards/counting those cards
            numberOfAcesInOne = CardRankCounter(cardValue1, CardRanks.Ace);
            numberOfTwosInOne = CardRankCounter(cardValue1,CardRanks.Two);
            numberOfThreesInOne = CardRankCounter(cardValue1,CardRanks.Three);
            numberOfFoursInOne = CardRankCounter(cardValue1, CardRanks.Four);
            numberOfFivesInOne = CardRankCounter(cardValue1, CardRanks.Five);
            numberOfSixesInOne = CardRankCounter(cardValue1,CardRanks.Six);
            numberOfSevensInOne = CardRankCounter(cardValue1,CardRanks.Seven);
            numberOfEightsInOne = CardRankCounter(cardValue1,CardRanks.Eight);
            numberOfNinesInOne = CardRankCounter(cardValue1,CardRanks.Nine);
            numberOfTensInOne = CardRankCounter(cardValue1,CardRanks.Ten);
            numberOfJacksInOne = CardRankCounter(cardValue1,CardRanks.Jack);
            numberOfQueensInOne = CardRankCounter(cardValue1,CardRanks.Queen);
            numberOfKingssInOne = CardRankCounter(cardValue1,CardRanks.King);


            //decide which poker hand they have:
            bool threeOfAKind = false;
            bool twoPair = false;
            bool onePair = false;



            if (numberOfAcesInOne == 3 || numberOfTwosInOne == 3 || numberOfThreesInOne == 3 || numberOfFoursInOne == 3 || numberOfFivesInOne == 3|| numberOfSixesInOne == 3|| numberOfSevensInOne ==3 || numberOfEightsInOne == 3|| numberOfNinesInOne ==3|| numberOfTensInOne == 3|| numberOfJacksInOne == 3|| numberOfQueensInOne == 3|| numberOfKingssInOne == 3)
            {
                threeOfAKind = true;

            }





















            Console.ReadLine();

        }





        //**********Shuffle Cards Here**********
        static Card[] shuffler(Card[] array)
        {
            int a = 0;
            int b = 51;
            int r = 0;
            Card cardNotLastOne;
            Card cardLastOne;
            Random randomNumber = new Random();

            while (b >= 1)
            {
                r = randomNumber.Next(a, b);

                cardNotLastOne = array[r];
                cardLastOne = array[b];

                array[r] = cardLastOne;
                array[b] = cardNotLastOne;

                b--;
            }
            return array;
        }



        static int CardRankCounter(Card[] setOfCards, CardRanks crdrnk)
        {
            int setLength = 5;
            int returnValue = 0;

            for (int n = 0; n < setLength; n++)
            {
                
                if (setOfCards[n].CardRank == crdrnk)
                {
                    returnValue++;
                }

            }


            return returnValue;
        }


        
    }

}

