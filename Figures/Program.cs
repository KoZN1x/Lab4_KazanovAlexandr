namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figure = new Figure(new Circle(23));
            var figures = new Figure(new Circle(23), new Rectangle(21, 24), new Triangle(7, 32, 10), new Circle(31), new Rectangle(15, 21));
            Console.WriteLine($"Perimeter of figure {figure.GetFigurePerimeter()}");
            Console.WriteLine($"Square of figure {figure.GetFigureSquare()}");
            Console.WriteLine($"Perimeter of all figures {figures.GetFigureArrayPerimeter()}");

        }
    }
}