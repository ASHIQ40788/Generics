using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericExtendMax<T> where T : IComparable
    {
        public T[] array;
        public GenericExtendMax(T[] array)
        {
            this.array = array;

        }

        //sorted the specified values
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }


        //returns the maximum value
        public T MaxValue( params T[] values)
        {
            T[] sortedArray = Sort(this.array);

            return sortedArray[sortedArray.Length - 1];

        }
        //public T MaxMethod()
        //{
        //    var max = MaxValue(this.value);
        //    return max;
        //}


        //Prints the maximum value
        public void PrintMaxValue()
        {
            var max = MaxValue(this.array);
            Console.WriteLine("Maximum value is :" + max);
        }
    }
}
