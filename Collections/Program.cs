using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "name1", "name2", "name3" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            List<string> names2 = new List<string> { "name1", "name2", "name3" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("name4");
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[0]);






        }
    }
}
