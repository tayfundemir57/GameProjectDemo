using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
   public interface ICampainServices
    {
        void Add(Campain campain);
        void Delete(Campain campain);

    }
}
