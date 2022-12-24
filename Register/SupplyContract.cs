using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class SupplyContract : Document
    {
        private string documentNumber;
        private string productType;
        private int productCount;
        private string date;

        public SupplyContract(string documentNumber, string productType, int productCount, string date)
        {
            this.documentNumber = documentNumber;
            this.productType = productType;
            this.productCount = productCount;
            this.date = date;
        }
        public override string DocumentInfo()
        {
            return $"Document number is {documentNumber}.\nProduct type is {productType}.\nAmount of product is {productCount}.\nDate: {date}";
        }
    }
}
