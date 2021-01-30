using System;
using System.Collections.Generic;
using exercicio1.Entities;

namespace exercicio1
{
    class Program
    {

        public static List<Employee> listEmployee = new List<Employee>();

        public static void cadastrarFunc()
        {

            Console.WriteLine("Enter the number of employess:");
            int numberEmployees = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberEmployees; i++)
            {

                Console.WriteLine($"Employee #{listEmployee.Count + 1} data:");
                var objEmployee = new Employee();

                Console.Write("OutSourced (y/n):?");
                var OutSourced = Console.ReadLine();

                Console.Write("Name: ");
                var nome = Console.ReadLine();
                Console.Write("Hours: ");
                var horas = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                var value = double.Parse(Console.ReadLine());

                if (OutSourced.ToLower() == "n")
                {
                    objEmployee = new Employee(nome, horas, value);
                }
                else
                {
                    Console.Write("Additional charge: ");
                    var additional = double.Parse(Console.ReadLine());

                    objEmployee = new OutsourcedEmployee(nome, horas, value, additional);
                }
                 objEmployee.ValuePerHour = objEmployee.payment();
                listEmployee.Add(objEmployee);

            }

            Console.WriteLine("=======================================================");
            listEmployee.ForEach(item => Console.WriteLine(item.ToString()));
            Console.WriteLine("=======================================================");
        }

        static void Main(string[] args)
        {
            cadastrarFunc();

            Console.ReadKey();

        }
    }
}
