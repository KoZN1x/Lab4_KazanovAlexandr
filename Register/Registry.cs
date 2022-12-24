using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class Registry
    {
        public Document[] documents;
        private int i = 0;
        public Registry()
        {
            documents = new Document[10];
        }
        public void AddDocument(Document document)
        {
            documents[i] = document;
            i++;
        }
        public string GetDocumentInfo(Document document)
        {
            return document.DocumentInfo();
        }
        
    }
}
