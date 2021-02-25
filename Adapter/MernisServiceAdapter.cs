using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Concrete;
using MernisServiceReference1;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Adapter
{
    public class MernisServiceAdapter : IPlayerServiceCheck
    {
        public bool CheckIfPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.PlayerNationalityId), player.PlayerFirstName, player.PlayerLastName,player.DateOfBirdh.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
