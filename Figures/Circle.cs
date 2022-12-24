using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Circle : ICalculationable
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Square()
        {
            return radius * radius * Math.PI;
        }
        public double Perimeter()
        {
            return (radius + radius) * Math.PI;
        }
    }
}
