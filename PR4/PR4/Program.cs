using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n;
            n = 10;
            double[] height, weight;
            height = new double[n];
            weight = new double[n];

            for (int i = 0; i < n; i++)
            {
                height[i] = rand.Next(149, 199);
                weight[i] = rand.Next(40, 110);
            }
            Console.WriteLine("----------------Неотсортированый массив---------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} работник: рост - {1}, вес - {2}", i + 1, height[i], weight[i]);
            }

            Array.Sort(height, weight);

            Console.WriteLine("");
            Console.WriteLine("----------------Отсортированый массив---------------");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} работник: рост - {1}, вес - {2}", i + 1, height[i], weight[i]);
            }
        }
    }
}
