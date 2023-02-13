using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string> { "tea","car","fish","house"};
            words.ForEach(e=>Console.WriteLine(e));
        }
    }
}
