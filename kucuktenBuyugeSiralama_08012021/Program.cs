using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kucuktenBuyugeSiralama_08012021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 26, 18, 7, -35, 65, 89 };
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int gecici = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = gecici;
                    }
                }
            }
            foreach (int number in numbers )
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}
