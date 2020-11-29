using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErbiumCustomListProj
{
    public class CustomList<T> : IEnumerable
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
            set => capacity = value;
        }
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
            
        }
        public CustomList<T> Zip(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> comboList = new CustomList<T>();
            { 
                for (int i = 0, j = 0; i < one.capacity || j < two.capacity; i++, j++)
                {
                    if (i < one.capacity && j < two.capacity)
                    {
                        comboList.Add(one[i]);
                        comboList.Add(two[j]);
                    }
                    else if(i < one.capacity)
                    {
                        comboList.Add(one[i]);
                    }
                    else if(j < two.capacity)
                    {
                        comboList.Add(two[j]);
                    }
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
        public static CustomList<T> operator- (CustomList<T> one,CustomList<T> two)
        {
            CustomList<T> oneList = new CustomList<T>();
            CustomList<T> twoList = new CustomList<T>();
            CustomList<T> comboList = new CustomList<T>();
            for (int i=0; i < one.count; i++)
            {
                oneList.Add(one[i]);
            }
            for (int i = 0; i < two.count; i++)
            {
                twoList.Add(two[i]);
            }
            for (int i = 0; i < oneList.count; i++)
            {
                foreach(T item in oneList)
                {
                    if(twoList[i].Equals(item))
                    {
                        oneList.Remove(item);
                        twoList.Remove(item);
                        break;
                    }
                }
                comboList = oneList + twoList;
                
            }
            return comboList;
        }
        
        public void Add(T valueToAdd)
        {
            if (count == capacity)
            {
                ExtendArray(capacity * 2);
            }
            _items[count] = valueToAdd;
            count++;
        }
        public void ExtendArray(int num)
        {
            T[] largerArray = new T[num];
            largerArray = CopyArray(largerArray);
            _items = largerArray;
            capacity = num;
        }
        public T[] CopyArray(T[] array)
        {
            for (int i = 0; i < Count; i++)
            {
                array[i] = _items[i];
            }
            return array;
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
        public override string ToString() 
        {
            string retVal = string.Empty;
            foreach (T item in this)
            {
                if (string.IsNullOrEmpty(retVal))
                {
                    retVal += item.ToString();
                }
                else
                {
                    retVal += string.Format(" {0}", item);
                }
            }
            return retVal;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
            }
        }
    }
}
