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
        public T this[int i]
        { 
            //get & set => return
            get { return _items[i]; }
            set { _items[i] = value; }   
            //return null if access request is outside of capacity
        }
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
            if (count < capacity)
            {
                _items[count] = valueToAdd;
                count++;
            }
            else if(count == capacity)
            {
                capacity += capacity;
                count++;
            }
        }
        public void Index() //Maybe i should call this in the Add function once finished
        {
            //Assign a number value to every item in the list starting at 0 'foreach'
            //create a get => and set => property for index value 'make them public'
        }
        public void Remove(int i)
        {
            //return value of accessed index
            //remove value from list
            //count--
            //if count reaches half of total capacity) capacity -= (capacity/2)
        }
    }
}
