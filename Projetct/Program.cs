using System;
using System.Collections.Generic;
using Projetct.Entities;
using System.Globalization;

namespace Projetct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employes> list = new List<Employes>();

            Console.Write("Enter the number of employes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employes #{i} data: ");
                Console.Write("Outsouced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsoucedEmployes(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employes(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENT");
            foreach (Employes emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
