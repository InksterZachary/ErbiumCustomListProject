using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErbiumCustomListProj
{
    public class CustomList<T>
    {
        T[] _items;
        private int count;
        public int Count
        {
            get => count;
        }
        private int capacity;
        public int Capacity
        {
            get => capacity;
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }
        public void Add(T valueToAdd)
        {
            if (count < 4)
            {
                _items[count] = valueToAdd;
                count++;
            }
            else if(count >= 4)
            {
                capacity += capacity;
                count++;
            }
        }
    }
}
