using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static Dictionary<char, int> frequency(string input)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ' || c == ',') 
                    continue;

                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            return freq;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            
            string[] parts = input.Split(',');

            foreach (string part in parts)
            {
                string word = part.Trim(); 
                Dictionary<char, int> result = frequency(word);

                
                foreach (var e in result)
                {
                    Console.Write($"{e.Key}={e.Value}, ");
                }
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
