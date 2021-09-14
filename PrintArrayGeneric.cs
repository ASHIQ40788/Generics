using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PrintArrayGeneric
    {
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("Displaying integer array elements");
            foreach (var element in array)
            {
                Console.Write(element + "\t");
            }
        }
    }
}
