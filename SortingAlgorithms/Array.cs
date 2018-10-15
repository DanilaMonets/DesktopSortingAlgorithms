using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Array
    {
        private List<int> arr;

        public int Count
        {
            get
            {
                return arr.Count;
            }
            private set { }
        }
        public int Size
        {
            get
            {
                return arr.Capacity;
            }
            private set { }
        }

        public Array()
        {
            arr = new List<int>();
        }
        public Array(int n)
        {
            arr = new List<int>(n);
            RandomFill();
        }
        public Array(Array a)
        {
            arr = new List<int>(a.Count);
            for (int i = 0; i < arr.Capacity; ++i)
            {
                arr.Add(a[i]);
            }
        }

        private void RandomFill()
        {
            Random r = new Random();
            for (int i = 0; i < arr.Capacity; ++i)
            {
                arr.Add(r.Next(1, 10));
            }
        }

        public void Add(int value)
        {
            arr.Add(value);
        }
        public void Remove(int value)
        {
            arr.Remove(value);
        }

        public void Swap(int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < arr.Count; ++i)
            {
                s = String.Concat(s, arr[i].ToString());
            }
            return s;
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
            
    }
}
