using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InvalidRadiusException : Exception
    {
        //overide the property Message of Exception class

        //public override string Message
        //{
        //    get
        //    {
        //        return "Invalid radius";
        //    }
        //}

        public double Radius { get; set; }

        public InvalidRadiusException() : base("Invalid radius")
        {

        }
        public InvalidRadiusException(double radius)  : base ("Invalid radius: " +  radius)
        {
            this.Radius = radius;
        }
    }
}
