using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 3, 1, 4, 6 };
            int max = array1[0];
            int min = array1[0];
            for (int i=1; i < array1.Length; i++)

            {
                if (array1[i] >max)
                {
                    max = array1[i];
                }
                if (array1[i]<min)
                {
                    min = array1[i];
                }
            }
            Console.WriteLine("Maximum number is :" + max);
            Console.WriteLine("Minimum number is :" + min);
            Console.ReadLine();
        }
    }
}
