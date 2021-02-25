using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using MernisServiceReference1;
using GameProjectDemo.Adapter;

namespace GameProjectDemo.Entities
{
    public interface IPlayerServices 
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);

    }

}
