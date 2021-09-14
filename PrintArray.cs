using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PrintArray
    {
        public static void ToPrint(int[] intArray)
        {
            Console.WriteLine("Displaying integer array elements");
            foreach (int element in intArray)
            {
                Console.Write(element +"\t");
            }
        }
        public static void ToPrint(double[] intArray)
        {
            Console.WriteLine("Displaying double array elements");
            foreach (double element in intArray)
            {
                Console.Write(element +"\t");
            }


        }
        public static void ToPrint(char[] intArray)
        {
            Console.WriteLine("Displaying char array elements");
            foreach (char element in intArray)
            {
                Console.Write(element + "\t");
            }


        }


    }
}

