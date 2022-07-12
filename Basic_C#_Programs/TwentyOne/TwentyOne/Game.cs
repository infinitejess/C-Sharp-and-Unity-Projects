using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game    //abstract locks code down
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }  //common to all games, keeping it generic
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets;  } set { _bets = value;  } }

        public abstract void Play();   //every single class that inherited from game class have to have Play()

        public virtual void ListPlayers()  //looping thru players and writing to console
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
