using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Triangle : ICalculationable
    {
        private double AB;
        private double BC;
        private double AC;
        public Triangle (double AB, double BC, double AC)
        {
            this.AB = AB;
            this.BC = BC;
            this.AC = AC;
        }
        public double Square()
        {
            double semiperimeter = (AB + BC + AC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - AB) * (semiperimeter - BC) * (semiperimeter - AC));
        }
        public double Perimeter()
        {
            return AB + BC + AC;
        }
    }
}
