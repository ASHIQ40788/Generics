﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MaxNumber
    {
        public static int FindMax(int first,int second,int third)
        {
            int fes = first.CompareTo(second);
            if (first.CompareTo(second)>0 && first.CompareTo(third)>0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("2 or more nubers are equal");
                return 0; 
            }
            
        }
    }
}
