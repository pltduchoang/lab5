﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle
    {
        public double Radius { get; set; }
        public Circle (double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidRadiusException();
            }
            else
            {
                Console.WriteLine("Good Job");
            }

            Radius = radius;
        }
    }
}
