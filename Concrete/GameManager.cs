using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class GameManager : IGameServices
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName,game.GameType,game.GamePrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName, game.GameType, game.GamePrice);
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName, game.GameType, game.GamePrice);
        }
    }
}
