using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Figure
    {
        private ICalculationable figure;
        private ICalculationable[] figures;

        public Figure(ICalculationable figure)
        {
                this.figure = figure;
        }

        public Figure(params ICalculationable[] figures)
        {
            this.figures = figures;
        }

        public double GetFigureSquare()
        {
            return figure.Square();
        }

        public double GetFigurePerimeter()
        {
            return figure.Perimeter();
        }

        public double GetFigureArrayPerimeter()
        {
            double result = 0;
            for (int i = 0; i < figures.Length; i++)
            {
                result += figures[i].Perimeter();
            }
            return result;
        }
    }
}
