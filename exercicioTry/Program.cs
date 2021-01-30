using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicioTry.Entities;
using exercicioTry.Entities.exceptions;

namespace exercicioTry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                var number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/mm/yyyy): ");
                var checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy): ");
                var checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());


                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
