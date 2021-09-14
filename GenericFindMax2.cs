using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericFindMax2<T> where T : IComparable
    {
        public T first, second, third;

        public GenericFindMax2(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;

        }
        public T FindMax(T first, T second, T third)
        {
            if(first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("all words are equal");
                return default;
            }

        }
        public T MaxNumb()

        {
            return FindMax(first, second, third);
        }
    }
    
}
