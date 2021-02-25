using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Concrete;

namespace GameProjectDemo.Concrete
{
    public class SalesManager : ISalesServices
    {
        
        public void sales(Player player,Game game, Campain campain)
        {

            double indirim = game.GamePrice;

            if (campain.CampainDiscount == 25)
            {
                indirim = (indirim * 0.75);

                Console.WriteLine("Müşteri : " + player.PlayerFirstName + "  " + player.PlayerLastName + "'e " +
                    game.GameName + " İsimli Oyun " + game.GamePrice + " TL'den " + " % " + campain.CampainDiscount + " " + campain.CampainName + " ile " + indirim + " TL fiyata satışı gerçekleşmiştir.");
            }
            else
            {

                Console.WriteLine("Müşteri : " + player.PlayerFirstName + "  " + player.PlayerLastName + "'e " +
                    game.GameName + " İsimli Oyun " + game.GamePrice + " TL fiyata satışı gerçekleşmiştir."+ " " +campain.CampainName);
            }

        }
    }
}
