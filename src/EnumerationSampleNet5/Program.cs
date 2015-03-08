using System;
using System.Collections.Generic;

namespace EnumerationSampleNet5
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            List<string> titles = new List<string>() { "raja", "rani", "mandiri" };

            //lambda sample
            titles.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Is a collection of titles in a kingdom");

            // Display the contents of the list using the Print method.
            Console.WriteLine("Can also print using a function");
            titles.ForEach(Print);

            // The following demonstrates the anonymous method feature of C# 
            // to display the contents of the list to the console.
            Console.WriteLine("Can also print using a delegate");
            titles.ForEach(delegate (string title)
            {
                Console.WriteLine(title);
            });
            Console.Read();
        }

        private static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
