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

            string[] cardsuits = new string[14];
            cardsuits[0] = "Ace"; cardsuits[1] = "Two"; cardsuits[2] = "Three"; cardsuits[3] = "Four"; cardsuits[4] = "Five"; cardsuits[5] = "Six"; cardsuits[6] = "Seven"; cardsuits[7] = "Eight"; cardsuits[8] = "Nine"; cardsuits[9] = "Ten"; cardsuits[10] = "Jack"; cardsuits[11] = "Queen"; cardsuits[12] = "King";
            string[] hand1 = new string[4];

            foreach (CardSuits crdsut in Enum.GetValues(typeof(CardSuits)))
            {
                playingCard.CardSuit = crdsut;
                foreach (CardRanks crdrnk in Enum.GetValues(typeof(CardRanks)))
                {


                    playingCard.CardRank = crdrnk;
                    cards[i] = playingCard;
                    i++;
                }
            }

            //Shuffling cards here:
            shuffledCards = shuffler(cards);



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
            //Hand two symbolic rep:
            for (int cardInHand = 0; cardInHand < 5; cardInHand++)
            {
                if (cardValue2[cardInHand].CardRank == CardRanks.Ace)
                {
                    rank = "A";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Two)
                {
                    rank = "2";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Three)
                {
                    rank = "3";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Four)
                {
                    rank = "4";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Five)
                {
                    rank = "5";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Six)
                {
                    rank = "6";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Seven)
                {
                    rank = "7";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Eight)
                {
                    rank = "8";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Nine)
                {
                    rank = "9";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Ten)
                {
                    rank = "T";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Jack)
                {
                    rank = "J";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.Queen)
                {
                    rank = "Q";
                }
                if (cardValue2[cardInHand].CardRank == CardRanks.King)
                {
                    rank = "K";
                }


                if (cardValue2[cardInHand].CardSuit == CardSuits.Clubs)
                {
                    suit = "♣".ToString();
                }
                if (cardValue2[cardInHand].CardSuit == CardSuits.Diamonds)
                {
                    suit = "♦".ToString();
                }
                if (cardValue2[cardInHand].CardSuit == CardSuits.Hearts)
                {
                    suit = "♥".ToString();
                }
                if (cardValue2[cardInHand].CardSuit == CardSuits.Spades)
                {
                    suit = "♠".ToString();
                }

                handTwoSymbolicRep[cardInHand] = (rank + suit);
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

            Console.WriteLine();
            Console.WriteLine();


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

            int numberOfHeartsInOne = 0;
            int numberOfSpadesInOne = 0;
            int numberOfClubsInOne = 0;
            int numberOfDiamondsInOne = 0;





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


            //Checking first deck for same card suits/ counting those cards
            numberOfHeartsInOne = CardSuitCounter(cardValue1, CardSuits.Hearts);
            numberOfSpadesInOne = CardSuitCounter(cardValue1, CardSuits.Spades);
            numberOfClubsInOne = CardSuitCounter(cardValue1, CardSuits.Clubs);
            numberOfDiamondsInOne = CardSuitCounter(cardValue1, CardSuits.Diamonds);


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


            int numberOfHeartsInTwo = 0;
            int numberOfSpadesInTwo = 0;
            int numberOfClubsInTwo = 0;
            int numberOfDiamondsInTwo = 0;


            //Checking second deck for same rank cards / counting those cards
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

            //Checking first deck for same card suits/ counting those cards
            numberOfHeartsInOne = CardSuitCounter(cardValue1, CardSuits.Hearts);
            numberOfSpadesInOne = CardSuitCounter(cardValue1, CardSuits.Spades);
            numberOfClubsInOne = CardSuitCounter(cardValue1, CardSuits.Clubs);
            numberOfDiamondsInOne = CardSuitCounter(cardValue1, CardSuits.Diamonds);



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

            //decide which poker hand they have:
            bool royalFlush_Two = false;
            bool straightFlush_Two = false;
            bool fourOfAKind_Two = false;
            bool fullHouse_Two = false;
            bool flush_Two = false;
            bool straight_Two = false;
            bool threeOfAKind_Two = false;
            bool twoPair_Two = false;
            bool onePair_Two = false;
            bool highCard_Two = false;



            //need all the other types of poker hands below:
            //need : all of second hand..


            //find which type of hand hand one is:
            if ((numberOfSpadesInOne == 5 || numberOfHeartsInOne == 5 || numberOfJacksInOne == 5 || numberOfDiamondsInOne == 5) && (numberOfKingssInOne == 1 && numberOfQueensInOne == 1 && numberOfJacksInOne == 1 && numberOfTensInOne == 1 && numberOfNinesInOne == 1))
            {
                royalFlush_One = true;
                Console.WriteLine("Hand one: Royal Flush");
            }

            if ((cardValue1[0].CardRank == CardRanks.King && cardValue1[1].CardRank == CardRanks.Queen && cardValue1[2].CardRank == CardRanks.Jack && cardValue1[3].CardRank == CardRanks.Ten && cardValue1[4].CardRank == CardRanks.Nine) || (cardValue1[0].CardRank == CardRanks.Queen && cardValue1[1].CardRank == CardRanks.Jack && cardValue1[2].CardRank == CardRanks.Ten && cardValue1[3].CardRank == CardRanks.Nine && cardValue1[4].CardRank == CardRanks.Eight) || (cardValue1[0].CardRank == CardRanks.Jack && cardValue1[1].CardRank == CardRanks.Ten && cardValue1[2].CardRank == CardRanks.Nine && cardValue1[3].CardRank == CardRanks.Eight && cardValue1[4].CardRank == CardRanks.Seven) || (cardValue1[0].CardRank == CardRanks.Ten && cardValue1[1].CardRank == CardRanks.Nine && cardValue1[2].CardRank == CardRanks.Eight && cardValue1[3].CardRank == CardRanks.Seven && cardValue1[4].CardRank == CardRanks.Six) || (cardValue1[0].CardRank == CardRanks.Nine && cardValue1[1].CardRank == CardRanks.Eight && cardValue1[2].CardRank == CardRanks.Seven && cardValue1[3].CardRank == CardRanks.Six && cardValue1[4].CardRank == CardRanks.Five) || (cardValue1[0].CardRank == CardRanks.Eight && cardValue1[1].CardRank == CardRanks.Seven && cardValue1[2].CardRank == CardRanks.Six && cardValue1[3].CardRank == CardRanks.Five && cardValue1[4].CardRank == CardRanks.Four) || (cardValue1[0].CardRank == CardRanks.Seven && cardValue1[1].CardRank == CardRanks.Six && cardValue1[2].CardRank == CardRanks.Five && cardValue1[3].CardRank == CardRanks.Four && cardValue1[4].CardRank == CardRanks.Three) || (cardValue1[0].CardRank == CardRanks.Six && cardValue1[1].CardRank == CardRanks.Five && cardValue1[2].CardRank == CardRanks.Four && cardValue1[3].CardRank == CardRanks.Three && cardValue1[4].CardRank == CardRanks.Two) || (cardValue1[0].CardRank == CardRanks.Five && cardValue1[1].CardRank == CardRanks.Four && cardValue1[2].CardRank == CardRanks.Three && cardValue1[3].CardRank == CardRanks.Two && cardValue1[4].CardRank == CardRanks.Ace))
            {
                if (numberOfSpadesInOne == 5 || numberOfHeartsInOne == 5 || numberOfJacksInOne == 5 || numberOfDiamondsInOne == 5)
                {
                    straightFlush_One = true;
                    Console.WriteLine("Hand one: Straight Flush");
                }

                else
                {
                    straight_One = true;
                    Console.WriteLine("Hand one: Straight");
                }
            }



            if((numberOfAcesInOne == 2 || numberOfTwosInOne == 2 || numberOfThreesInOne == 2 || numberOfFoursInOne == 2 || numberOfFivesInOne == 2 || numberOfSixesInOne == 2 || numberOfSevensInOne == 2 || numberOfEightsInOne == 2 || numberOfNinesInOne == 2 || numberOfTensInOne == 2 || numberOfJacksInOne == 2 || numberOfQueensInOne == 2 || numberOfKingssInOne == 2) && (numberOfAcesInOne == 3 || numberOfTwosInOne == 3 || numberOfThreesInOne == 3 || numberOfFoursInOne == 3 || numberOfFivesInOne == 3 || numberOfSixesInOne == 3 || numberOfSevensInOne == 3 || numberOfEightsInOne == 3 || numberOfNinesInOne == 3 || numberOfTensInOne == 3 || numberOfJacksInOne == 3 || numberOfQueensInOne == 3 || numberOfKingssInOne == 3))
            {
                fullHouse_One = true;
                Console.WriteLine("Hand one: Full House");
            }


            if (numberOfHeartsInOne == 5|| numberOfDiamondsInOne == 5|| numberOfClubsInOne == 5|| numberOfSpadesInOne == 5)
            {
                flush_One = true;
                Console.WriteLine("Hand one: Flush");
            }



            if ((flush_One == false) && (numberOfAcesInOne == 4 || numberOfTwosInOne == 4 || numberOfThreesInOne == 4 || numberOfFoursInOne == 4 || numberOfFivesInOne == 4 || numberOfSixesInOne == 4 || numberOfSevensInOne == 4 || numberOfEightsInOne == 4 || numberOfNinesInOne == 4 || numberOfTensInOne == 4 || numberOfJacksInOne == 4 || numberOfQueensInOne == 4 || numberOfKingssInOne == 4))
            {
                fourOfAKind_One = true;
                Console.WriteLine("Hand one: Four of a Kind");
            }


            if ((flush_One == false && fourOfAKind_One == false) && (numberOfAcesInOne == 3 || numberOfTwosInOne == 3 || numberOfThreesInOne == 3 || numberOfFoursInOne == 3 || numberOfFivesInOne == 3 || numberOfSixesInOne == 3 || numberOfSevensInOne == 3 || numberOfEightsInOne == 3 || numberOfNinesInOne == 3 || numberOfTensInOne == 3 || numberOfJacksInOne == 3 || numberOfQueensInOne == 3 || numberOfKingssInOne == 3))
            {
                threeOfAKind_One = true;
                Console.WriteLine("Hand one: Three of a Kind.");
            }

            if (flush_One == false && fourOfAKind_One == false && threeOfAKind_One == false)
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
                    Console.WriteLine("Hand one: One Pair.");
                }
                if (numberOfPairs_One == 2)
                {
                    twoPair_One = true;
                    Console.WriteLine("Hand one: Two Pair.");
                }

            }

            if (royalFlush_One == false && straightFlush_One == false && fourOfAKind_One == false && fullHouse_One == false && flush_One == false && straight_One == false && threeOfAKind_One == false && twoPair_One == false && onePair_One == false)
            {
                highCard_One = true;
                Console.WriteLine("Hand one: High Card.");
            }


            //find which type of program hand two is:

            if ((numberOfSpadesInTwo == 5 || numberOfHeartsInTwo == 5 || numberOfJacksInTwo == 5 || numberOfDiamondsInTwo == 5) && (numberOfKingssInTwo == 1 && numberOfQueensInTwo == 1 && numberOfJacksInTwo == 1 && numberOfTensInTwo == 1 && numberOfNinesInTwo == 1))
            {
                royalFlush_Two = true;
                Console.WriteLine("Hand two: Royal Flush");
            }

            if ((cardValue2[0].CardRank == CardRanks.King && cardValue2[1].CardRank == CardRanks.Queen && cardValue2[2].CardRank == CardRanks.Jack && cardValue2[3].CardRank == CardRanks.Ten && cardValue2[4].CardRank == CardRanks.Nine) || (cardValue2[0].CardRank == CardRanks.Queen && cardValue2[1].CardRank == CardRanks.Jack && cardValue2[2].CardRank == CardRanks.Ten && cardValue2[3].CardRank == CardRanks.Nine && cardValue2[4].CardRank == CardRanks.Eight) || (cardValue2[0].CardRank == CardRanks.Jack && cardValue2[1].CardRank == CardRanks.Ten && cardValue2[2].CardRank == CardRanks.Nine && cardValue2[3].CardRank == CardRanks.Eight && cardValue2[4].CardRank == CardRanks.Seven) || (cardValue2[0].CardRank == CardRanks.Ten && cardValue2[1].CardRank == CardRanks.Nine && cardValue2[2].CardRank == CardRanks.Eight && cardValue2[3].CardRank == CardRanks.Seven && cardValue2[4].CardRank == CardRanks.Six) || (cardValue2[0].CardRank == CardRanks.Nine && cardValue2[1].CardRank == CardRanks.Eight && cardValue2[2].CardRank == CardRanks.Seven && cardValue2[3].CardRank == CardRanks.Six && cardValue2[4].CardRank == CardRanks.Five) || (cardValue2[0].CardRank == CardRanks.Eight && cardValue2[1].CardRank == CardRanks.Seven && cardValue2[2].CardRank == CardRanks.Six && cardValue2[3].CardRank == CardRanks.Five && cardValue2[4].CardRank == CardRanks.Four) || (cardValue2[0].CardRank == CardRanks.Seven && cardValue2[1].CardRank == CardRanks.Six && cardValue2[2].CardRank == CardRanks.Five && cardValue2[3].CardRank == CardRanks.Four && cardValue2[4].CardRank == CardRanks.Three) || (cardValue2[0].CardRank == CardRanks.Six && cardValue2[1].CardRank == CardRanks.Five && cardValue2[2].CardRank == CardRanks.Four && cardValue2[3].CardRank == CardRanks.Three && cardValue2[4].CardRank == CardRanks.Two) || (cardValue2[0].CardRank == CardRanks.Five && cardValue2[1].CardRank == CardRanks.Four && cardValue2[2].CardRank == CardRanks.Three && cardValue2[3].CardRank == CardRanks.Two && cardValue2[4].CardRank == CardRanks.Ace))
            {
                if (numberOfSpadesInTwo == 5 || numberOfHeartsInTwo == 5 || numberOfJacksInTwo == 5 || numberOfDiamondsInTwo == 5)
                {
                    straightFlush_Two = true;
                    Console.WriteLine("Hand two: Straight Flush");
                }

                else
                {
                    straight_Two = true;
                    Console.WriteLine("Hand two: Straight");
                }
            }



            if ((numberOfAcesInTwo == 2 || numberOfTwosInTwo == 2 || numberOfThreesInTwo == 2 || numberOfFoursInTwo == 2 || numberOfFivesInTwo == 2 || numberOfSixesInTwo == 2 || numberOfSevensInTwo == 2 || numberOfEightsInTwo == 2 || numberOfNinesInTwo == 2 || numberOfTensInTwo == 2 || numberOfJacksInTwo == 2 || numberOfQueensInTwo == 2 || numberOfKingssInTwo == 2) && (numberOfAcesInTwo == 3 || numberOfTwosInTwo == 3 || numberOfThreesInTwo == 3 || numberOfFoursInTwo == 3 || numberOfFivesInTwo == 3 || numberOfSixesInTwo == 3 || numberOfSevensInTwo == 3 || numberOfEightsInTwo == 3 || numberOfNinesInTwo == 3 || numberOfTensInTwo == 3 || numberOfJacksInTwo == 3 || numberOfQueensInTwo == 3 || numberOfKingssInTwo == 3))
            {
                fullHouse_Two = true;
                Console.WriteLine("Hand two: Full House");
            }


            if (numberOfHeartsInTwo == 5 || numberOfDiamondsInTwo == 5 || numberOfClubsInTwo == 5 || numberOfSpadesInTwo == 5)
            {
                flush_Two = true;
                Console.WriteLine("Hand two: Flush");
            }



            if ((flush_Two == false) && (numberOfAcesInTwo == 4 || numberOfTwosInTwo == 4 || numberOfThreesInTwo == 4 || numberOfFoursInTwo == 4 || numberOfFivesInTwo == 4 || numberOfSixesInTwo == 4 || numberOfSevensInTwo == 4 || numberOfEightsInTwo == 4 || numberOfNinesInTwo == 4 || numberOfTensInTwo == 4 || numberOfJacksInTwo == 4 || numberOfQueensInTwo == 4 || numberOfKingssInTwo == 4))
            {
                fourOfAKind_Two = true;
                Console.WriteLine("Hand two: Four of a Kind");
            }


            if ((flush_Two == false && fourOfAKind_Two == false) && (numberOfAcesInTwo == 3 || numberOfTwosInTwo == 3 || numberOfThreesInTwo == 3 || numberOfFoursInTwo == 3 || numberOfFivesInTwo == 3 || numberOfSixesInTwo == 3 || numberOfSevensInTwo == 3 || numberOfEightsInTwo == 3 || numberOfNinesInTwo == 3 || numberOfTensInTwo == 3 || numberOfJacksInTwo == 3 || numberOfQueensInTwo == 3 || numberOfKingssInTwo == 3))
            {
                threeOfAKind_Two = true;
                Console.WriteLine("Hand two: Three of a Kind.");
            }

            if (flush_Two == false && fourOfAKind_Two == false && threeOfAKind_Two == false)
            {
                int numberOfPairs_Two = 0;

                if (numberOfAcesInTwo == 2)
                {
                    numberOfPairs_Two++;
                }

                if (numberOfTwosInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfThreesInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfFoursInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfKingssInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfFivesInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfSixesInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfSevensInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfEightsInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfNinesInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfTensInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfJacksInTwo == 2)
                {
                    numberOfPairs_Two++;
                }
                if (numberOfQueensInTwo == 2)
                {
                    numberOfPairs_Two++;
                }

                if (numberOfPairs_Two == 1)
                {
                    onePair_Two = true;
                    Console.WriteLine("Hand two: One Pair.");
                }
                if (numberOfPairs_Two == 2)
                {
                    twoPair_Two = true;
                    Console.WriteLine("Hand two: Two Pair.");
                }

            }

            if (royalFlush_Two == false && straightFlush_Two == false && fourOfAKind_Two == false && fullHouse_Two == false && flush_Two == false && straight_Two == false && threeOfAKind_Two == false && twoPair_Two == false && onePair_Two == false)
            {
                highCard_Two = true;
                Console.WriteLine("Hand two: High Card.");
            }












            //End of program.
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


        static int CardSuitCounter(Card[] setOfCards, CardSuits cardsuit)
        {
            int setLength = 5;
            int returnValue = 0;

            for (int n = 0; n < setLength; n++)
            {

                if (setOfCards[n].CardSuit == cardsuit)
                {
                    returnValue++;
                }

            }


            return returnValue;
        }

    }

}

