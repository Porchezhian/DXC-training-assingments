using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shapes
    {
        private double result;
        
        public Shapes(double side)
        {
            this.result = side * side;
        }
        public Shapes(double length, double width)
        {
            this.result = length * width;
        }
        public Shapes(double height, double Base, string type)
        {
            this.result = 0.5*height * Base;
        }
        public Shapes(double radius, string type)
        {
            this.result = 3.14 * radius * radius;
        }
        public double getArea()
        {
            return this.result;
        }
    }
}
