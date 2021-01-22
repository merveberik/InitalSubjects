using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count); //count bir propertydir. kaç eleman olduğunu verir.

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count); //propfull ile sehirler2 nin de countunu alabilirim.
        }
    }
    class MyList<T>
    {
        T[] items; //we had to do new.
        //Construct
        public MyList()
        {
            items = new T[0]; //Created array
        }
        public void Add(T item) //when type new, we assign type.
        {
            T[] tempArray = items;
            items = new T[items.Length + 1]; //item number length is increased 1.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //we will add last item 

        }
       
        //propfull dedik
        //private int _count;

        public int Count
        {
            get { return items.Length; } //array uzunluğu
            //set { _count = value; }//set istemiyorum
        }

    }
}
