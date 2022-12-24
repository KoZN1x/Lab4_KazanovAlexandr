using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rectangle : ICalculationable
    {
        private double width;
        private double length;
        
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public double Square()
        {
            return width * length;
        }
        public double Perimeter()
        {
            return 2 * (width + length);
        }

    }
}
