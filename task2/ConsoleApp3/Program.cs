using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" input product-quantity");
            string input = Console.ReadLine();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] data;

            while (!input.Equals("end"))
            {
                data = input.Split("-");
                if (dictionary.ContainsKey(data[0]))
                {
                    int value;
                    dictionary.TryGetValue(data[0], out value);
                    value += int.Parse(data[1]);
                    Console.WriteLine(value + " value");
                }
                if (!dictionary.ContainsKey(data[0]))
                {
                    dictionary.Add(data[0],int.Parse(data[1]));
                   
                }
               
                input = Console.ReadLine();
            }
            dictionary = dictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach(var d in dictionary)
            {
                Console.WriteLine(d);
            }
        }

    }
}
