using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class ConsignmentNote : Document
    {
        private int monthlyTotalSum;
        private string documentNumber;
        private string date;
        private string departmentCode;

        public ConsignmentNote(int monthlyTotalSum, string documentNumber, string date, string departmentCode)
        {
            this.monthlyTotalSum = monthlyTotalSum;
            this.documentNumber = documentNumber;
            this.date = date;
            this.departmentCode = departmentCode;
        }

        public override string DocumentInfo()
        {
            return $"Monthly total sum is {monthlyTotalSum}.\nDocument number is {documentNumber}.\nDate of conclusion: {date}.\nDepartment code is: {departmentCode}";
        }
    }
}
