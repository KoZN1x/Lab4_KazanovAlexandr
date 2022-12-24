namespace Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Anna = new Director();
            Anna.PrintPosition();
            var Mihail = new Worker();
            Mihail.PrintPosition();
            var Oleg = new Accountant();
            Oleg.PrintPosition();
        }
    }
}