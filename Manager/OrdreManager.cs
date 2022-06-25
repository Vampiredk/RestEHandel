using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restware.Models;

namespace Restware.Manager
{
    public class OrdreManager
    {
        private static int _nextId = 1;

        private static List<Ordre> _OrdreList = new List<Ordre>()
        {
        };


        public List<Ordre> GetAll()
        {
            return _OrdreList;
        }

        public Ordre GetById(int ID)
        {
            return _OrdreList.Find(Meas => Meas.Id == ID);
        }

        public void Delete(int id)
        {
            Ordre ordre = _OrdreList.Find(ordre => ordre.Id == id);
            if (ordre == null) return;
            _OrdreList.Remove(ordre);
        }

        public void Add(Ordre value)
        {
            value.Id = _nextId++;
            _OrdreList.Add(value);
        }

        public Ordre Update(int id, Ordre value)
        {
            Ordre item = _OrdreList.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Id = value.Id;
            item.KundeEmail = value.KundeEmail;
            item.TotalPrice = value.TotalPrice;
            item.Wares = value.Wares;
            return item;
        }
    }
}