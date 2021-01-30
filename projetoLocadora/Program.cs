using System;
using System.Globalization;
using projetoLocadora.Entities;
using projetoLocadora.Services;
namespace projetoLocadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");

            Console.WriteLine("Car model: ");
            var model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm):");
            var start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm):");
            var finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour:");
            var hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day:");
            var day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour,day, new BrazilTaxService());

            rentalService.processinvoice(carRental);

            Console.WriteLine($"Invoices: {carRental.invoice}");

            Console.ReadKey();
        }
    }
}
