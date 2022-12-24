using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Director : IPrintable
    {
        private string position = "Director";

        public void PrintPosition()
        {
            Console.WriteLine(position);
        }
    }
}
