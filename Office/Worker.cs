using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Worker : IPrintable
    {
        private string position = "Worker";

        public void PrintPosition()
        {
            Console.WriteLine(position);
        }
    }
}
