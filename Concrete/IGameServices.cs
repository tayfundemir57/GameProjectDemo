using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
    public interface IGameServices
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
