﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is: " + Functions.sum(7, 8));

            var json = JsonConvert.SerializeObject("Hello");

            Console.ReadKey();
        }
    }
}
