using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolecode
{
    internal class Item
    {
        public string Name;
        public int Id;
        public bool IsStack;
        public int Count;

        public Item(string name, int id, bool isStack, int count = 1)
        {
            Name = name;
            Id = id;
            IsStack = isStack;
            Count = count;
        }
    }
}
