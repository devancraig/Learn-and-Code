using System;
using System.Collections.Generic;
using System.Text;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            void CreateCard()
            {
                //Need 80 cards eventually
                //Creates a random card
                for (int i = 0; i < 12; i++)
                {
                    cards.Add(new Set.Card((SetEnum.CardShape)RandomNumber(), (SetEnum.CardColor)RandomNumber(), (SetEnum.CardShade)RandomNumber(), (SetEnum.CardNumber)RandomNumber()));
                }

            }
            CreateCard();

            void PrintCard()
            {
                foreach (var item in cards)
                {
                    Console.WriteLine(item.Color + " " + item.Number + " " + item.Shade + " " + item.Shape);
                }
            }

            int RandomNumber()
            {
                var rand = new Random();
                var randNum = rand.Next(3);

                return randNum;
            }

            bool CheckSimilaritiesColor(){
                bool check = false;

                for (int i = 0; i < cards.Count; i++)
                {
                    int count = 0;
                    List<Card> simCards = new List<Card>();
                    for (int j = 1; j < cards.Count; j++)
                    {
                        if (cards[i].Color == cards[j].Color)
                        {
                            simCards.Add(new Card(cards[j].Shape, cards[j].Color, cards[j].Shade, cards[j].Number));
                            count++;
                        }
                    }
                    if(count >= 3){
                        CheckDifference(cards[i], simCards);
                    }
                }

                return check;
            }

            bool CheckDifference(Card startCard, List<Card> checkCard){
                bool check = false;
                

                return check;
            }
            
            PrintCard();

        }


    }
}
