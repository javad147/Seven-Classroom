﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Class1
    {
        public static int Sum()
        {
            return -1;
        }
        public static int Sum(int a)
        {
            return a;
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int Sum(params int[] nums)
        {
            int sum = 0;
        }
        return Sum;




    }
}