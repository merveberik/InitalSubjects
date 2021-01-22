using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Generic class
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
            items = new T[items.Length+1]; //item number length is increased 1.
            for(int i=0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //we will add last item 
        }
    }
}
