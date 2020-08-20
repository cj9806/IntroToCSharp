using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesPractice
{
    class Employee
    {
        string firstName;
        string lastName;
        string years;
        int yearsOfExperiance = 0;

        public void EmployeeInfo()
        {
            Console.WriteLine("please enter your first name.");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name");
            lastName = Console.ReadLine();
            Console.WriteLine("How many years of experience do you have?");
            bool validChoice = false;
            while (!validChoice)
            {
                years = Console.ReadLine();
                if (int.TryParse(years, out int a))
                {
                    int yearsOfExperience = int.Parse(years);
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("How many years of experience do you have?");
                }
            }
            Console.WriteLine($"Your name is {firstName} {lastName}, and you have {yearsOfExperiance} years of experiance.");


        }
    }
}
