using ArraysPractice;
using System;
using System.ComponentModel.DataAnnotations;

namespace ClassesPractice
{
    class Program
    {
        static void Main()
        {
            //employee test
            Employee employee = new Employee();
            employee.EmployeeInfo();
            //tv practice
            Telelvision tv = new Telelvision();
            tv.volume();
            for (int i = 0; i < 5; i++)
            {
                tv.decreaseVolume();
                tv.volume();
                tv.increaseChannel();
                tv.channel();
            }
            //piggy bank test
            PiggyBank pb = new PiggyBank();
            Console.WriteLine($"you have ${pb.balance()} in your accont.");
            pb.deposit(150F);
            Console.WriteLine($"you have ${pb.balance()} in your accont.");
            pb.withdraw(56.75F);
            Console.WriteLine($"you have ${pb.balance()} in your accont.");
        }
    }
}
