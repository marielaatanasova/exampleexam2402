using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examexample2402
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            char[] resultCh = new char[10];

            resultCh = input.ToCharArray();
            Array.Reverse(resultCh);
            Console.WriteLine($"input >>> {input} \nresult >>>>>> {string.Join("", resultCh)}");
            string result = string.Join("", resultCh);
            Console.WriteLine(result);

          if (string.Equals(input,result)) //(string.Compare(input, result, true)==0)  //if (input == result)
            {
                Console.WriteLine("Suvpada");
            }
            result = input.Substring(1, 5);
            Console.WriteLine($">>>>> {result}");

            Array.Sort(resultCh);
            Console.WriteLine($"input >>> {input} \nresult >>>>>> {string.Join("", resultCh)}");
            Array.Clear(resultCh, 0, 2);
            Console.WriteLine($"input >>> {input} \nresult >>>>>> {string.Join("", resultCh)}");



        }
    }
}
