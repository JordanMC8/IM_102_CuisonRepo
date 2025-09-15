using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    class Program
    {
        static bool comparer(int currentNumber)
        {
            bool isPrime = true;

            if (currentNumber <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int y = 2; y <= Math.Sqrt(currentNumber); y++)
                {
                    if (currentNumber % y == 0)
                    {
                        isPrime = false;

                        break;
                    }
                }
            }
            return isPrime;
        }
        static void ConvertCurrency(double dollars, out double peso, out double yen)
        {
            const double pesoRate = 57.17;
            const double yenRate = 146.67;

            peso = dollars * pesoRate;
            yen = dollars * yenRate;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            String [] input = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>();
            

            foreach (string x in input)
            {
                if (int.TryParse(x, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Please enter integer numbers only.");
                }
            }
            
            for (int x = 0; x < numbers.Count; x++)
            {
                int currentNumber = numbers[x];
                
                if(currentNumber <= 1)
                {
                    Console.WriteLine($"{x + 1}. {currentNumber} Neither Prime or Composite");
                }
                else if (comparer(currentNumber))
                {
                    Console.WriteLine($"{x + 1}. {currentNumber} Prime");
                }
                else
                {
                    Console.WriteLine($"{x + 1}. {currentNumber} Composite");
                }
            }



            Console.Write("Enter currency in ($): ");
            string input1 = Console.ReadLine();
            string[] parts = input1.Split(',');

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(Y)");

            foreach (string part in parts)
            {
                string trimmedPart = part.Trim();

                if (double.TryParse(trimmedPart, out double dollars))
                {
                    ConvertCurrency(dollars, out double peso, out double yen);
                    Console.WriteLine($"{dollars}\t\t{Math.Round(peso, 2)}\t\t{Math.Round(yen, 2)}");
                }
                else
                {
                    Console.WriteLine($"Invalid input: {trimmedPart}");
                }
            }

            Console.ReadKey();
        }
    }
}
