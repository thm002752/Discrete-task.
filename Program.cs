using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            List<int> perfectNumbers = new List<int>();

            // Prompt user for input
            Console.Write("Enter starting number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter ending number: ");
            n2 = int.Parse(Console.ReadLine());

            // Check for perfect numbers between n1 and n2
            for (int i = n1; i <= n2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    perfectNumbers.Add(i);
                }
            }

            // Print out the list of perfect numbers
            Console.Write("Perfect numbers between {0} and {1}: ", n1, n2);
            foreach (int num in perfectNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
    