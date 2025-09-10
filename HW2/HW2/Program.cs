using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            List<List<double>> numbers = new List<List<double>>();
            double sum = 0.0;

            for (int x = 0; x < rows; x++)
            {
                Console.WriteLine($"Row {x + 1}");
                List<double> rowList = new List<double>(); 

                for (int y = 0; y < cols; y++)
                {
                    Console.Write($"Enter number{y + 1}: ");
                    double value = double.Parse(Console.ReadLine());

                    rowList.Add(value);
                    sum += value;
                }

                numbers.Add(rowList);
            }

            Console.WriteLine("\nThe numbers are:");
            foreach (List<double> row in numbers)
            {
                foreach (double value in row)
                {
                    Console.Write($"{Round(value, 1)} ");
                }
                Console.WriteLine();
            }

            int count = rows * cols;
            double average = sum / count;

            Console.WriteLine($"\nSum: {Round(sum , 1)} ; Average: {Round(average , 1)}");
            Console.ReadKey();
        }
    }
}
