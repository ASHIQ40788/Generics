using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Please enter the number of elements need to added into integer array");
            //        int n=Convert.ToInt32(Console.ReadLine());
            //        int[] intArray = new int[n];
            //    for (int i=0;i<n;i++)
            //    {
            //        intArray[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            int[] intArray = { 10, 20, 40, 50 };
            //PrintArray.ToPrint(intArray);
            double[] doubleArray = { 10.20, 20.53, 40.56, 50.90 };
            //PrintArray.ToPrint(doubleArray);
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            //PrintArray.ToPrint(charArray);

            //PrintArrayGeneric.ToPrint<int>(intArray);
            //PrintArrayGeneric.ToPrint<double>(doubleArray);
            //PrintArrayGeneric.ToPrint<char>(charArray);

            //new PrintArrayGenericMethod<int>(intArray).toPrint();
            //new PrintArrayGenericMethod<double>(doubleArray).toPrint();
            //new PrintArrayGenericMethod<char>(charArray).toPrint();

            //Console.WriteLine("Maximum number is :{0} out of {1} {2} {3} ",MaxNumber.FindMax(20, 10, 28),20,10,28);

            //Console.WriteLine("Maximum float number is : "+FloatMaxNumber.FindMax(20f, 10f, 28f));

            //Console.WriteLine("Maximum float number is : " + StringMaxNumber.FindMax("hello", "welcome", "good"));


            //Console.WriteLine("Maximum number is :{0} out of {1} {2} {3} ", GenericFindMax<int>.FindMax(20, 10, 28), 20, 10, 28);

            //Console.WriteLine(new GenericFindMax2<int>(10, 8, 7).MaxNumb()); 
            

            GenericExtendMax<int> generic = new GenericExtendMax<int>(intArray);
            GenericExtendMax<double> generic1 = new GenericExtendMax<double>(doubleArray);
            GenericExtendMax<char> generic2 = new GenericExtendMax<char>(charArray);
            generic.PrintMaxValue();
            generic1.PrintMaxValue();
            generic2.PrintMaxValue();
            Console.ReadLine();

            //Console.ReadKey();
        }
    }
}
       