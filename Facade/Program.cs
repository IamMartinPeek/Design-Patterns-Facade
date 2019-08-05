using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SetUp start = new SetUp();
            IDictionary<string, string> information = start.LoadSetUpData(); //Program.cs knows nothing about how complex it is to load the data


        }
    }
}
