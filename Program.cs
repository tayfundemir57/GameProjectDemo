using System;
using GameProjectDemo.Entities;
using GameProjectDemo.Concrete;
using MernisServiceReference1;
using GameProjectDemo.Adapter;


namespace GameProjectDemo
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************** OYUNCU_EKLE_GÜNCELLE_SİL_***************");

            // Oyuncu Ekle + Güncelle + Sil


            Player player1 = new Player() { PlayerId = 1, PlayerFirstName = "TAYFUN", PlayerLastName = "DEMİR", DateOfBirdh =new DateTime(1992,1,1), PlayerNationalityId = "22222222222" };
            Player player2 = new Player() { PlayerId = 2, PlayerFirstName = "MUSTAFA", PlayerLastName = "DEMİR", DateOfBirdh = new DateTime(1970, 1, 1), PlayerNationalityId = "11111111111" };
            //T.C. kimlik bilgisi ve doğum yılını doğru girildiğinde Mernis kontrolü yapıldı. Çalışıyor.
            
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());

            playerManager.Add(player1);
            playerManager.Add(player2);

            Console.WriteLine("");

            playerManager.Update(player2);
            playerManager.Delete(player1);

            Console.WriteLine("");
            Console.WriteLine("************** OYUN_KAYIT ***************");
                                  
            Game game1 = new Game() { GameName = "Shadow Tactics", GameType = "Taktiksel", GamePrice = 24 };
            Game game2 = new Game() { GameName = "Sniper Elite 4", GameType = "Gizlilik  ", GamePrice = 80 };
            Game game3 = new Game() { GameName = "Tomb Raider", GameType = "Macera", GamePrice = 75 };

            Game[] games1 = new Game[] { game1, game2, game3 };

            foreach (var game in games1)
            {
            Console.WriteLine("Oyun Adı : "   + game.GameName + " / Oyun Türü : " + game.GameType+ "/ Oyun Fiyatı : "+ game.GamePrice + " TL");
                //Console.WriteLine("\t Oyunun ismi: " + game.GameName + "---> " + "Oyunun türü: " + game.GameType + "---> " + "Oyunun fiyatı: " + game.GameName);
            }

            Console.WriteLine("");
            Console.WriteLine("************** KAMPANYA ***************");
                                   

            Campain campain1 = new Campain() { CampainName = "Bahar Kampanyası İndirimi", CampainDiscount = 25 };
            Campain campain2 = new Campain() { CampainName = "Kampanya Uygulanmadı.", CampainDiscount = 0 };

            ICampainManager campainManager = new ICampainManager();

            campainManager.Add(campain1);
            campainManager.Add(campain2);

            Console.WriteLine("");
            Console.WriteLine("************** SATIŞ ***************");

            SalesManager salesManager = new SalesManager();
            
            salesManager.sales(player1, game1, campain1);
            salesManager.sales(player2, game2, campain2);

        }

    }
}
