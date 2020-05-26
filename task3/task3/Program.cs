using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a sentence");
            string input = Console.ReadLine();
            string[] data;
            data = input.ToLower().Split(",");
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in data)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            dict = dict.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
            }
        }
       

    }
}

