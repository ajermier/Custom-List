using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyCustomList<T> : IEnumerable<T> where T : IComparable<T>
    {
        //member variables
        public T[] myArr;
        private int count;
        private int capacity;

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }

        //constructors
        public MyCustomList()
        {
            count = 0;
            capacity = 0;
            myArr = new T[0];
        }
        public MyCustomList(int length)
        {
            count = length;
            if (length <= 4) capacity = 4;
            else capacity = (int)Math.Pow(2, (int)Math.Ceiling(Math.Log(length) / Math.Log(2)));
            myArr = new T[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return myArr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)myArr).GetEnumerator();
        }

        //methods
        public void Add(T item)
        {
            count = count + 1;
            if (count <= capacity)
            {
                myArr[count-1] = item;
            }
            else
            {
                ReplaceWithLargerArray(item);
            }
        }
        private void ReplaceWithLargerArray(T item)
        {
            MyCustomList<T> replace = new MyCustomList<T>(count);
            for (int i = 0; i < count - 1; i++)
            {
                replace.myArr[i] = myArr[i];
            }
            replace.myArr[count - 1] = item;
            myArr = replace.myArr;
            count = replace.Count;
            capacity = replace.Capacity;
        }
        public bool Remove(T item)
        {
            bool removed = false;
            
            for (int i = 0; i < count; i++)
            {
                if (myArr[i].Equals(item))
                {
                    removed = true;
                    RemoveAndShift(i);
                    return removed;
                }
            }
            return removed;
        }
        public bool RemoveAll(T item)
        {
            bool removed = false;

            for (int i = 0; i < count; i++)
            {
                if (myArr[i].Equals(item))
                {
                    removed = true;
                    RemoveAndShift(i);
                    i--;
                }
            }
            return removed;
        }
        private void RemoveAndShift(int index)
        {
            count--;
            for (int j = index; j < count + 1; j++)
            {
                myArr[j] = myArr[j + 1];
            }
        }
        public override string ToString()
        {
            string s = "";
            string newString = "";
            T[] value = myArr;

            if(Count == 0)
            {
                return "EMPTY LIST";
            }
            if (myArr.GetType().Namespace == "System")
            {
                for (int i = 0; i < Count; i++)
                {
                    if (value[i] == null) newString = " ";
                    else newString = $"{value[i]}";
                    if (i == Count - 1) s = s + newString;
                    else s = s + newString + ", ";
                }
            }
            else
            {
                for(int i = 0; i < Count; i++)
                {
                    if (value[i] == null) newString = " ";
                    else newString = $"{value[i].GetType().Name}";
                    if (i == Count - 1) s = s + newString;
                    else s = s + newString + ", ";
                }
            }
            return s;
        }
        public static MyCustomList<T> operator + (MyCustomList<T> list1, MyCustomList<T> list2)
        {
            MyCustomList<T> replace = new MyCustomList<T>(list1.Count + list2.Count);

            for(int i = 0; i < list1.Count; i++)
            {
                replace.myArr[i] = list1.myArr[i];
            }
            for(int j = 0; j < list2.Count; j++)
            {
                replace.myArr[list1.Count + j] = list2.myArr[j];
            }
            return replace;
        }
        public static MyCustomList<T> operator - (MyCustomList<T> list1, MyCustomList<T> list2)
        {
            int i = 0;

            while(i < list1.Count)
            {
                int j = 0;
                while(j < list2.Count)
                {
                    if (list1.myArr[i].Equals(list2.myArr[j]))
                    {
                        list1.RemoveAll(list2.myArr[j]);
                        list2.RemoveAll(list2.myArr[j]);
                        j--;
                    }
                    j++;
                }
                i++;
            }
            return list1;
        }
        public MyCustomList<T> ZipLists(MyCustomList<T> list1, MyCustomList<T> list2)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            MyCustomList<T> replace = new MyCustomList<T>(list1.Count + list2.Count);

            while(i < list1.Count + list2.Count)
            {
                if(j < list1.Count)
                {
                    replace.myArr[i] = list1.myArr[j];
                    i++;
                    j++;
                }
                if(k < list2.Count)
                {
                    replace.myArr[i] = list2.myArr[k];
                    i++;
                    k++;
                }
            }
            return replace;
        }
        public void SortAsc()
        {
            for(int i = 1; i < Count; i++)
            {
                for(int j = 0; j < Count - 1; j++)
                {
                    if(myArr[j].CompareTo(myArr[j + 1]) >= 0)
                    {
                        SwapPosition(ref myArr[j], ref myArr[j + 1]);
                    }
                }
            }
        }

        public void SwapPosition(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    //Custom test object class
    public class Car : IComparable<Car>
    {
        public int year; public string color; public double topSpeed;
        public Car(int year, string color, double topSpeed)
        {
            this.year = year;
            this.color = color;
            this.topSpeed = topSpeed;
        }

        //sortable by year
        public int CompareTo(Car other)
        {
            return year.CompareTo(other.year);
        }
    }
}

