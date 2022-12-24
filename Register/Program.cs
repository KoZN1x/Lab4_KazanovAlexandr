namespace Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ConsigmentNote = new ConsignmentNote(13214, "1234321", "20.10.2022", "321321");
            var EmployeeContract = new EmployeeContract("Alex", "1234321", "20.11.2022", "20.11.2023");
            var SupplyContract = new SupplyContract("12344321", "Phones", 14, "20.12.2022");
            var registry = new Registry();
            registry.AddDocument(ConsigmentNote);
            registry.AddDocument(EmployeeContract);
            registry.AddDocument(SupplyContract);
            Console.WriteLine(registry.GetDocumentInfo(ConsigmentNote));
            Console.WriteLine(registry.GetDocumentInfo(EmployeeContract));
            Console.WriteLine(registry.GetDocumentInfo(SupplyContract));
        }
    }
}