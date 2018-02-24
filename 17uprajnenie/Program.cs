using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17uprajnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int i = 0;
            int step = numbers[i];
            int sum = numbers[0];
            do
            {
                if (i + step < numbers.Length && i + step >= 0)
                {
                    i = step + i;
                    step = numbers[i];
                    sum += numbers[i];
                    Console.WriteLine(numbers[i]);

                }
                else
                { 
                if ((i + step >= numbers.Length || i - step <0 ) || (i + step <= 0 || i - step > numbers.Length))
                {
                    break;
                }
                
                    step = -1*step;
                }
            } while (true);
            Console.WriteLine(sum);
        }

    }
}


