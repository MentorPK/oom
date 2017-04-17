using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Player
    {
        public List<Card> Hand;

        public Player()
        {
            Hand = new List<Card>();
        }

        public void PullCards(GameState gamestate, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var idx = gamestate.rng.Next(gamestate.allcards.Count);
                Card card = gamestate.allcards[idx];
                Hand.Add(card);
            }
        }
    }
}
