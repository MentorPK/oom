using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class GameState
    {
        public Player player1;
        public Player player2;
        public List<Card> allcards;
        public Random rng;

        public GameState(Player gs_p1, Player gs_p2, List<Card> gs_allcards)
        {
            player1 = gs_p1;
            player2 = gs_p2;
            allcards = gs_allcards;
            rng = new Random();
        }
    }
}
