using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                Year = 2005,
                Make = "Acura",
                Model = "TSX",
            };

            Console.WriteLine($"{car.Year} {car.Make} {car.Model}");

        }
    }
}
