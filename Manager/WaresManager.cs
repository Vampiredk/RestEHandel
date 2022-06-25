using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restware.Models;

namespace Restware.Manager
{
    public class WaresManager
    {
        private static int _nextId = 6;

        private static List<Wares> _WaresList = new List<Wares>()
        {
            new Wares("Mælk", "Food",  42, 420, 1),
            new Wares("kebab", "Food", 67, 200, 2),
            new Wares("Tesla", "Car", 21, 3, 3),
            new Wares("Uran235", "Components", 9999, 1, 4),
            new Wares("Æble", "Food", 3, 37, 5)
        };
        private static List<Wares> _WaresCatagoriList = new List<Wares>()
        {

        };


        public List<Wares> GetAll()
        {
            return _WaresList;
        }

        public Wares GetById(int ID)
        {
            return _WaresList.Find(wares => wares.Id == ID);
        }

        public List<Wares> GetByType(string TYPE)
        {
            _WaresCatagoriList.Clear();
            foreach (Wares wares in _WaresList)
            {
                if (wares.Type == TYPE)
                {
                    _WaresCatagoriList.Add(wares);
                }
            }
            return _WaresCatagoriList;
        }

        public void Delete(int id)
        {
            Wares wares = _WaresList.Find(wares => wares.Id == id);
            if (wares == null) return;
            _WaresList.Remove(wares);
        }

        public void Add(Wares value)
        {
            value.Id = _nextId++;
            _WaresList.Add(value);
        }

        public Wares Update(int id, Wares value)
        {
            Wares item = _WaresList.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Id = value.Id;
            item.Name = value.Name;
            item.Price = value.Price;
            item.Stock = value.Stock;
            return item;
        }
    }
}