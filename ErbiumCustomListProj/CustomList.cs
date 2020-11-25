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
            get { return _items[i]; }
            set { _items[i] = value; }
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
        public static CustomList<T> operator+ (CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> myList = new CustomList<T>();
            foreach()
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
            else if (count == capacity)
            {
                capacity += capacity;
                count++;
            }
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }

            }
            return false;
        }
        public T RemoveAt(int index)
        {
            T removedItem = _items[index];
            for (int i = index; i < count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            count--;
            return removedItem;
        }
        public override string ToString() //Tried: ForEach, direct item
        {
            //I want this method to 
            //Turn each value in the list of items into a string
            return _items.ToString();
        }
        
    }
}
