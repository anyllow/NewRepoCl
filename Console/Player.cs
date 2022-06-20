using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolecode
{
    class Player
    {
        public string Name;
        public int Health;
        public int HealthMax;
        public int Power;
        public int PowerMax;
        public Inventory Inventory;

        public Player()
        {
            Inventory = new Inventory();
            Inventory.AddItem(new Item("Палка", 0, true, 6));
            Inventory.AddItem(new Item("Палка", 0, true, 3));
            Inventory.AddItem(new Item("Камень", 1, true, 2));
            Inventory.AddItem(new Item("Доска", 2, true, 5));

            HealthMax = 100;
            PowerMax = 10;

            Health = HealthMax;
            Power = PowerMax;
        }
    }
    class Inventory
    {
        public List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            if (items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (item.Id == items[i].Id && items[i].IsStack)
                    {
                        items[i].Count += item.Count;
                        break;
                    }
                    else if (i == items.Count - 1)
                    {
                        items.Add(item);
                        break;
                    }
                }
            }
            else
                items.Add(item);
        }
        public void GetAllItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}: {items[i].Name}, кол-во: {items[i].Count}");
            }
        }
    }
}
