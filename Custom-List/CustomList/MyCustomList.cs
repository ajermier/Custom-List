using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyCustomList<T> : IEnumerable<T>
    {
        //member variables
        public T[] myArr;
        private int countMyArr;

        public int Count { get { return countMyArr; } }

        //constructors
        public MyCustomList()
        {
            countMyArr = 0;
            myArr = new T[0];
        }
        public MyCustomList(int length)
        {
            countMyArr = length;
            myArr = new T[length];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return myArr[i];
            }
        }

        //methods
        public void Add(T item)
        {
            countMyArr = countMyArr + 1;
            MyCustomList<T> replace = new MyCustomList<T>(countMyArr);
            for(int i = 0; i < countMyArr - 1; i++)
            {
                replace.myArr[i] = myArr[i];
            }
            replace.myArr[countMyArr - 1] = item;
            myArr = replace.myArr;
        }
        public bool Remove(T item)
        {
            int length = countMyArr;
            bool removed = false;
            MyCustomList<T> replace = new MyCustomList<T>();
            for (int i = 0; i < length; i++)
            {
                if (myArr[i].Equals(item) && removed == false)
                {
                    removed = true;
                    countMyArr--;
                }
                else replace.Add(myArr[i]);
            }
            myArr = replace.myArr;
            return removed;
        }
        public bool RemoveAll(T item)
        {
            int length = countMyArr;
            bool removed = false;
            MyCustomList<T> replace = new MyCustomList<T>();
            for(int i = 0; i < length; i++)
            {
                if(myArr[i].Equals(item))
                {
                    removed = true;
                    countMyArr--;
                }
                else replace.Add(myArr[i]);
            }
            myArr = replace.myArr;
            return removed;
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
            for(int i = 0; i < list1.Count; i++)
            {
                for(int j = 0; j < list2.Count; j++)
                {
                    if (list1.myArr[i].Equals(list2.myArr[j]))
                    {
                        list1.RemoveAll(list2.myArr[j]);
                        list2.RemoveAll(list2.myArr[j]);
                        j = j - 1;
                    }
                }
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)myArr).GetEnumerator();
        }
    }
}

