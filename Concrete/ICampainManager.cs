using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Concrete;

namespace GameProjectDemo.Concrete
{
  public  class ICampainManager : ICampainServices
    {
        public void Add(Campain campain)
        {
            Console.WriteLine(campain.CampainName + " " + " % " + campain.CampainDiscount);
        }

        public void Delete(Campain campain)
        {
            Console.WriteLine(campain.CampainName + " " + " % " + campain.CampainDiscount);
        }
    }
}
