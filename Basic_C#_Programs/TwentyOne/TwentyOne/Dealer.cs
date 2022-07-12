using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }
        public void Deal(List<Card> Hand)  //method to deal, which involves having a hand
        {
            Hand.Add(Deck.Cards.First()); //adding card to hand from deck
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //creating string to log 
            Console.WriteLine(card); //print
            using (StreamWriter file = new StreamWriter(@"C:\Users\jessi\OneDrive\Documents\log.txt", true))  //logs each card dealt
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
           Deck.Cards.RemoveAt(0); //pass in index of where to remove (0 is first item)
        }
    }
}
