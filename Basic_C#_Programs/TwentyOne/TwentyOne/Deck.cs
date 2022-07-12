using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //contrcutor - always same name as class
        {
            Cards = new List<Card>();

            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j <4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1) 
        {
            for (int i = 0; i < times; i++)
            { 
                List<Card> TempList = new List<Card>(); //create temp empty list to store shuffled items
                Random random = new Random(); //create "random" object that we could use

                while (Cards.Count > 0) //take random cards, put in empty deck, do until down to 0 cards left
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]); //add to temp list
                    Cards.RemoveAt(randomIndex); //remove from deck
                }
                Cards = TempList;
            }
        }

        }
}
