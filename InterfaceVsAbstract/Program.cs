﻿using InterfaceVsAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Id = 1001,
                FirstName = "Manideep",
                LastName = "Nampally",
                AnnualSalary = 120000
            };
            Console.WriteLine(fullTimeEmployee.GetFullName());
            Console.WriteLine(fullTimeEmployee.GetMonthlySalary());

            Console.WriteLine("---------------------------");

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Id=1002,
                FirstName="Deep",
                LastName="Mani",
                HourlyPay=200,
                TotalHoursWorked=35
            };
            Console.WriteLine(partTimeEmployee.GetFullName());
            Console.WriteLine(partTimeEmployee.GetMonthlySalary());

            Console.WriteLine("-----------------------------");
        }
    }
}
