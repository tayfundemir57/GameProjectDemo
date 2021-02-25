using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
   public class Game : IEntity
    {
        
        public string GameName { get; set; }
        public string GameType { get; set; }
        public double GamePrice { get; set; }

    }
}
