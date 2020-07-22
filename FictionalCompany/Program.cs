using FictionalCompany.Entities;
using FictionalCompany.Entities.Enums;
using System;

namespace FictionalCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Department department = new Department(dept);
            Worker worker = new Worker(name, level, salary, department);

            Console.Write("How many contracts to this worker? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Enter #{0} contract data:", i);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = Convert.ToDouble(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = Convert.ToInt32(Console.ReadLine());

                HourContract contract = new HourContract(date, value, hours);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = Convert.ToInt32(monthAndYear.Substring(0,2));
            int year = Convert.ToInt32(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for {0}: {1}", monthAndYear, worker.Income(year, month).ToString("F2"));

        }
    }
}
