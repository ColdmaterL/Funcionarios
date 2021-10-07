using System;
using System.Collections.Generic;
using System.Text;
using Funcionarios.Entities;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, NumberEmployees, HoursOfWork;
            char RespostaOutSorced;
            string NameEmployee;
            double ValuePerHour, AdditionalCharge;
            List<Employees> Employee = new List<Employees>();
            Console.Write("Enter the number of employees: ");
            NumberEmployees = int.Parse(Console.ReadLine());
            for(i = 1; i <= NumberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsorced (y/n)? ");
                RespostaOutSorced = char.Parse(Console.ReadLine());
                switch (RespostaOutSorced)
                {
                    case 'y':
                        Console.Write("Name: ");
                        NameEmployee = Console.ReadLine();
                        Console.Write("Hours: ");
                        HoursOfWork = int.Parse(Console.ReadLine());
                        Console.Write("Value per hour: ");
                        ValuePerHour = double.Parse(Console.ReadLine());
                        Console.Write("Additional charge: ");
                        AdditionalCharge = double.Parse(Console.ReadLine());
                        Employee.Add(new OutsorcedEmployee(NameEmployee, HoursOfWork, ValuePerHour, AdditionalCharge));
                        break;
                    case 'n':
                        Console.Write("Name: ");
                        NameEmployee = Console.ReadLine();
                        Console.Write("Hours: ");
                        HoursOfWork = int.Parse(Console.ReadLine());
                        Console.Write("Value per hour: ");
                        ValuePerHour = double.Parse(Console.ReadLine());
                        Employee.Add(new Employees(NameEmployee, HoursOfWork, ValuePerHour));
                        break;
                }
            }
            Console.WriteLine("\nPAYMENTS: ");
            foreach(Employees emp in Employee)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
