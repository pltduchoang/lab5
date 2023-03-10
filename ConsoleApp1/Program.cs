using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double positiveRadius = 100;
            double negativeRadius = -100;
            double zeroRadius = 0;
            try
            {
                Circle positiveCircle = new Circle(positiveRadius);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("oh no~ something bad happened but we can still go on");
            }

           

            try 
            {
                Circle negativeCircle = new Circle(negativeRadius);
            } 
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("oh no~ something bad happened but we can still go on");
            }

            try
            {
                Circle zeroCircle = new Circle(zeroRadius);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("oh no~ something bad happened but we can still go on");
            }

            
        }
    }
}
