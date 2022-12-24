using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Accountant : IPrintable
    {
        private string position = "Accountant";

        public void PrintPosition()
        {
            Console.WriteLine(position);
        }
    }
}
