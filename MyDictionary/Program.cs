using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionary1 = new Dictionary<int, int>();
            dictionary1.Add(1, 3);

            MyDictionary<int, string> dictionary2 = new MyDictionary<int, string>();
            dictionary2.Add(2, "Adıyaman");
        }
    }
}
