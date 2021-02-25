using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Entities
{
   public class Campain : IEntity
    {
        public string CampainName { get; set; }
        public int CampainDiscount { get; set; }
               
    }
}
