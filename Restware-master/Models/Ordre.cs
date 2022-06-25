using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restware.Models
{
    public class Ordre
    {
        public string KundeEmail { get; set; }
        public int TotalPrice { get; set; }
        public string Wares { get; set; }
        public int Id { get; set; }

        public Ordre(string kundeemail, int totalprice, string wares, int id)
        {
            KundeEmail = kundeemail;
            TotalPrice = totalprice;
            Wares = wares;
            Id = id;
        }
        public Ordre() { }

        public override string ToString()
        {
            return KundeEmail + ", " + Wares + ", " + TotalPrice + " ";
        }
    }
}