using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Coding");
            myDictionary.Add(2, "Read");
            myDictionary.Add(3, "Sport");

            Console.WriteLine(myDictionary.Count);

        }
    }
}
