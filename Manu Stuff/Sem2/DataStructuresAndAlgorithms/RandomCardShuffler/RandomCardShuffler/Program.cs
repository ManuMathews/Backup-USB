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

            Card[] cardValue1 = new Card[5];
            Card[] cardValue2 = new Card[5];
            Card[] cardValue1Sybolic = new Card[5];
            Card[] cardValue2Sybolic = new Card[5];


            //how to use ascii in c#
            //http://www.softwareandfinance.com/CSharp/PrintASCII.html


            foreach (CardSuits crdsut in Enum.GetValues(typeof(CardSuits)))
            {
                playingCard.CardSuit = crdsut;
                foreach (CardRanks crdrnk in Enum.GetValues(typeof(CardRanks)))
                {


                    playingCard.CardRank = crdrnk;
                    cards[i] = playingCard;
                    //Console.WriteLine(cards[i]);
                    i++;
                }
            }

            //Shuffle cards here:

            shuffledCards = shuffler(cards);

            //i = 0;
            //while (i <= 51)
            //{
            //    Console.WriteLine(shuffledCards[i]);
            //    i++;
            //}


            //pick first five shuffled cards for first hand
            cardValue1[0].CardRank = shuffledCards[0].CardRank; cardValue1[0].CardSuit = shuffledCards[0].CardSuit;
            cardValue1[1].CardRank = shuffledCards[1].CardRank; cardValue1[1].CardSuit = shuffledCards[1].CardSuit;
            cardValue1[2].CardRank = shuffledCards[2].CardRank; cardValue1[2].CardSuit = shuffledCards[2].CardSuit;
            cardValue1[3].CardRank = shuffledCards[3].CardRank; cardValue1[3].CardSuit = shuffledCards[3].CardSuit;
            cardValue1[4].CardRank = shuffledCards[4].CardRank; cardValue1[4].CardSuit = shuffledCards[4].CardSuit;

            //pick second five shuffled cards for second hand
            cardValue2[0].CardRank = shuffledCards[5].CardRank; cardValue2[0].CardSuit = shuffledCards[5].CardSuit;
            cardValue2[1].CardRank = shuffledCards[6].CardRank; cardValue2[1].CardSuit = shuffledCards[6].CardSuit;
            cardValue2[2].CardRank = shuffledCards[7].CardRank; cardValue2[2].CardSuit = shuffledCards[7].CardSuit;
            cardValue2[3].CardRank = shuffledCards[8].CardRank; cardValue2[3].CardSuit = shuffledCards[8].CardSuit;
            cardValue2[4].CardRank = shuffledCards[9].CardRank; cardValue2[4].CardSuit = shuffledCards[9].CardSuit;


            //assigning symbolic representation to cards in hand 1 for display purposes..
            string[] handOneSymbolicRep = new string[5];   //hand one for display purposes
            string[] handTwoSymbolicRep = new string[5];   //hand two for display purposes
            string rank = ""; string suit = "";
            
            foreach (Card cardValue in cardValue1)
            {

                for (int cardInHand = 0; cardInHand < 5; cardInHand++)
                {
                    if (cardValue1[cardInHand].CardRank == CardRanks.Ace)
                    {
                        rank = "A";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Two)
                    {
                        rank = "2";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Three)
                    {
                        rank = "3";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Four)
                    {
                        rank = "4";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Five)
                    {
                        rank = "5";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Six)
                    {
                        rank = "6";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Seven)
                    {
                        rank = "7";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Eight)
                    {
                        rank = "8";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Nine)
                    {
                        rank = "9";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Ten)
                    {
                        rank = "T";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Jack)
                    {
                        rank = "J";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.Queen)
                    {
                        rank = "Q";
                    }
                    if (cardValue1[cardInHand].CardRank == CardRanks.King)
                    {
                        rank = "K";
                    }


                    if (cardValue1[cardInHand].CardSuit == CardSuits.Clubs)
                    {
                        suit = "♣".ToString();
                    }
                    if (cardValue1[cardInHand].CardSuit == CardSuits.Diamonds)
                    {
                        suit = "♦".ToString();
                    }
                    if (cardValue1[cardInHand].CardSuit == CardSuits.Hearts)
                    {
                        suit = "♥".ToString();
                    }
                    if (cardValue1[cardInHand].CardSuit == CardSuits.Spades)
                    {
                        suit = "♠".ToString();
                    }

                    handOneSymbolicRep[cardInHand] = (rank + suit);

                }











                //Displaying the two decks:
                Console.WriteLine("\nHand One: ");
                for (int h = 0; h < 5; h++)
                {
                    Console.Write(handOneSymbolicRep[h] + " ");
                }
                Console.WriteLine("\nHand Two: ");
                for (int h2 = 0; h2 < 5; h2++)
                {
                    Console.Write(handTwoSymbolicRep[h2] + " ");
                }




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

                //Checking first deck for same rank cards / counting those cards
                numberOfAcesInOne = CardRankCounter(cardValue1, CardRanks.Ace);
                numberOfTwosInOne = CardRankCounter(cardValue1, CardRanks.Two);
                numberOfThreesInOne = CardRankCounter(cardValue1, CardRanks.Three);
                numberOfFoursInOne = CardRankCounter(cardValue1, CardRanks.Four);
                numberOfFivesInOne = CardRankCounter(cardValue1, CardRanks.Five);
                numberOfSixesInOne = CardRankCounter(cardValue1, CardRanks.Six);
                numberOfSevensInOne = CardRankCounter(cardValue1, CardRanks.Seven);
                numberOfEightsInOne = CardRankCounter(cardValue1, CardRanks.Eight);
                numberOfNinesInOne = CardRankCounter(cardValue1, CardRanks.Nine);
                numberOfTensInOne = CardRankCounter(cardValue1, CardRanks.Ten);
                numberOfJacksInOne = CardRankCounter(cardValue1, CardRanks.Jack);
                numberOfQueensInOne = CardRankCounter(cardValue1, CardRanks.Queen);
                numberOfKingssInOne = CardRankCounter(cardValue1, CardRanks.King);


                int numberOfAcesInTwo = 0;
                int numberOfTwosInTwo = 0;
                int numberOfThreesInTwo = 0;
                int numberOfFoursInTwo = 0;
                int numberOfFivesInTwo = 0;
                int numberOfSixesInTwo = 0;
                int numberOfSevensInTwo = 0;
                int numberOfEightsInTwo = 0;
                int numberOfNinesInTwo = 0;
                int numberOfTensInTwo = 0;
                int numberOfJacksInTwo = 0;
                int numberOfQueensInTwo = 0;
                int numberOfKingssInTwo = 0;

                //Checking first deck for same rank cards / counting those cards
                numberOfAcesInTwo = CardRankCounter(cardValue2, CardRanks.Ace);
                numberOfTwosInTwo = CardRankCounter(cardValue2, CardRanks.Two);
                numberOfThreesInTwo = CardRankCounter(cardValue2, CardRanks.Three);
                numberOfFoursInTwo = CardRankCounter(cardValue2, CardRanks.Four);
                numberOfFivesInTwo = CardRankCounter(cardValue2, CardRanks.Five);
                numberOfSixesInTwo = CardRankCounter(cardValue2, CardRanks.Six);
                numberOfSevensInTwo = CardRankCounter(cardValue2, CardRanks.Seven);
                numberOfEightsInTwo = CardRankCounter(cardValue2, CardRanks.Eight);
                numberOfNinesInTwo = CardRankCounter(cardValue2, CardRanks.Nine);
                numberOfTensInTwo = CardRankCounter(cardValue2, CardRanks.Ten);
                numberOfJacksInTwo = CardRankCounter(cardValue2, CardRanks.Jack);
                numberOfQueensInTwo = CardRankCounter(cardValue2, CardRanks.Queen);
                numberOfKingssInTwo = CardRankCounter(cardValue2, CardRanks.King);


                //decide which poker hand they have:
                bool royalFlush_One = false;
                bool straightFlush_One = false;
                bool fourOfAKind_One = false;
                bool fullHouse_One = false;
                bool flush_One = false;
                bool straight_One = false;
                bool threeOfAKind_One = false;
                bool twoPair_One = false;
                bool onePair_One = false;
                bool highCard_One = false;



                if (numberOfAcesInOne == 3 || numberOfTwosInOne == 3 || numberOfThreesInOne == 3 || numberOfFoursInOne == 3 || numberOfFivesInOne == 3 || numberOfSixesInOne == 3 || numberOfSevensInOne == 3 || numberOfEightsInOne == 3 || numberOfNinesInOne == 3 || numberOfTensInOne == 3 || numberOfJacksInOne == 3 || numberOfQueensInOne == 3 || numberOfKingssInOne == 3)
                {
                    threeOfAKind_One = true;

                }

                if (threeOfAKind_One == false)
                {
                    int numberOfPairs_One = 0;

                    if (numberOfAcesInOne == 2)
                    {
                        numberOfPairs_One++;
                    }

                    if (numberOfTwosInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfThreesInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfFoursInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfKingssInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfFivesInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfSixesInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfSevensInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfEightsInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfNinesInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfTensInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfJacksInOne == 2)
                    {
                        numberOfPairs_One++;
                    }
                    if (numberOfQueensInOne == 2)
                    {
                        numberOfPairs_One++;
                    }

                    if (numberOfPairs_One == 1)
                    {
                        onePair_One = true;
                    }
                    if (numberOfPairs_One == 2)
                    {
                        twoPair_One = true;
                    }

                }

                if (royalFlush_One == false && straightFlush_One == false && fourOfAKind_One == false && fullHouse_One == false && flush_One == false && straight_One == false && threeOfAKind_One == false && twoPair_One == false && onePair_One == false)
                {
                    highCard_One = true;

                }








                Console.ReadLine();

            }


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


            //used for counting the number of specific ranked cards there are in the hand.
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

