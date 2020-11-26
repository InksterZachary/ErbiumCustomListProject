using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErbiumCustomListProj
{
    public class CustomList<T> //: IEnumerator<T>
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
        
        public static CustomList<T> Zip(CustomList<T> one, CustomList<T> two) //Actually I think this is the zipper method so I added the equality check
        {
            CustomList<T> comboList = new CustomList<T>();
            if (one.count == two.count)
            {
                for (int i = 0, j = 0; i < one.count && j < two.count; i++, j++)
                {
                    comboList.Add(one[i]);
                    comboList.Add(two[j]);
                }
            }
            return comboList;
        }
        public static CustomList<T> operator+ (CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> comboList = new CustomList<T>();
            for (int i = 0; i < one.count; i++)
            {
                comboList.Add(one[i]);
            }
            for(int j = 0; j < two.count; j++)
            {
                comboList.Add(two[j]);
            }
            return comboList;
        }
        public static CustomList<T> operator- (CustomList<T> one,CustomList<T> two) //Just saw 'distinct<>' maybe useful
        {
            CustomList<T> comboList = new CustomList<T>();
            for (int i = 0; i < one.count; i++)
            {
                for (int j = 0; j < two.count; j++)
                {
                    if (two[i].Equals(one[i]))
                    {
                         one.Remove(one[i]);
                         two.Remove(two[j]);
                    }
                }
            }
            for (int i=0,j=0; i < one.count && j < two.count; i++,j++)
            {
                comboList.Add(one[i]);
                comboList.Add(two[j]);
            }
            return comboList;
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
