using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;
using GameProjectDemo.Concrete;

namespace GameProjectDemo
{
  public  class Player:IEntity
    {
        public int PlayerId { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public DateTime DateOfBirdh { get; set; }
        public string PlayerNationalityId { get; set; }

    }
}
