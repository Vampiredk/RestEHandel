using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restware.Models
{
    public class Wares
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int Id { get; set; }

        public Wares(string name, string type, int price, int stock, int id)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Id = id;
            Type =  type;
        }
        public Wares() { }

        public override string ToString()
        {
            return Name + ", " + Price + ", " + Stock + " ";
        }
    }
}