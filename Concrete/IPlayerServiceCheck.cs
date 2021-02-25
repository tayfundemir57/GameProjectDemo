using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference1;
using GameProjectDemo.Adapter;

namespace GameProjectDemo.Concrete
{
 public interface IPlayerServiceCheck
    {
        bool CheckIfPlayer(Player player);
    }
}
