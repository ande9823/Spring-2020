using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Showcase
    {
        public List<Game> games;
        int maxGames;

        public Showcase(int size)
        {
            games = new List<Game>();
            maxGames = size;
        }
        
        public void AddGame(Game game)
        {
            if (games.Count < maxGames)
                games.Add(game);
        }

        public void RemoveGame(Game game)
        {
            games.Remove(game);
        }

        public bool RemoveGame(int index)
        {
            if (index < games.Count)
            {
                games.RemoveAt(index);
                return true;
            }
            return false;
        }

        public void Show()
        {
            for (int i = 0; i < games.Count; i++)
            {
                Console.WriteLine("["+ i +"] " + games[i].name);
                //Console.WriteLine("[{0}] {1}", i, games[i].name);
            }
        }

        //framework (opstilling, highlight osv.)
        //access to games
    }
}
