using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class EmployeeContract : Document
    {
        public string name;
        private string documentNumber;
        private string date;
        private string endDate;

        public EmployeeContract(string name, string documentNumber, string date, string endDate)
        {
            this.name = name;
            this.documentNumber = documentNumber;
            this.date = date;
            this.endDate = endDate;
        }

        public override string DocumentInfo()
        {
            return $"Name of employee: {name}.\nDocument number is {documentNumber}.\nDate of conclusion: {date}.\nContract end date: {endDate}";
        }
    }
}
