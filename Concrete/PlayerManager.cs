using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;
using GameProjectDemo.Concrete;
using MernisServiceReference1;
using GameProjectDemo.Adapter;

namespace GameProjectDemo
{
   public class PlayerManager :IPlayerServices
    {
        IPlayerServiceCheck _playerServiceCheck;


        public PlayerManager (IPlayerServiceCheck playerServiceCheck)
        {
            _playerServiceCheck = playerServiceCheck;
        }
                

            public void Add(Player player)
            {
                if (_playerServiceCheck.CheckIfPlayer(player))
                {
                   // Console.WriteLine("Kişisel Bigileri Doğrulandı.. " + player.PlayerFirstName,player.PlayerLastName);

                Console.WriteLine("Mernis Bilgisi Doğrulandı " +player.PlayerId + "  " + "Oyuncu : " + player.PlayerFirstName
              + "  " + player.PlayerLastName + "  " + player.DateOfBirdh.Year + "  " + player.PlayerNationalityId + " Oyuncu Ekleme İşlemi Yapıldı..  ");
            }
                else
                {
                Console.WriteLine("Kişisel Bilgileri Geçersiz..! " + player.PlayerFirstName + " "+ player.PlayerLastName);
                }

            }

                

        public void Update ( Player player)
        {
            Console.WriteLine(player.PlayerId + "  " + "Oyuncu : " + player.PlayerFirstName
               + "  " + player.PlayerLastName + "  " + player.DateOfBirdh.Year + "  " + player.PlayerNationalityId + " Oyuncu Güncelleme İşlemi Yapıldı..  ");

        }


        public void Delete (Player player)
        {
            Console.WriteLine(player.PlayerId + "  " + "Oyuncu : " + player.PlayerFirstName
               + "  " + player.PlayerLastName + "  " + player.DateOfBirdh.Year + "  " + player.PlayerNationalityId + " Oyuncu Silme İşlemi Yapıldı..  ");
        }

       
    }
}
