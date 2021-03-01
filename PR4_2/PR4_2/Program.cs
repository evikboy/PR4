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
            string[] name;
            double[] price;
            name = new string[] { "Samsung Portable SSD T5", "Kingston SSDnow A400" , "Samsung 970 Evo series" , "Kingston SSD KC 600", "Kingston SSD KC 2500",
            "Samsung PM 883" , "Kingston DC 500R", "Goodram SSD CL 100"};
            price = new double[name.Length];

            for (int i = 0; i < name.Length; i++)
            {
                price[i] = rand.Next(700, 25000);
            }
            Console.WriteLine("----------------Неотсортированый массив---------------");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("{0} SSD: имя - {1}, цена - {2}", i + 1, name[i], price[i]);
            }

            Array.Sort(price, name);

            Console.WriteLine("");
            Console.WriteLine("----------------Отсортированый массив---------------");

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("{0} SSD: имя - {1}, цена - {2}", i + 1, name[i], price[i]);
            }
        }
    }
}