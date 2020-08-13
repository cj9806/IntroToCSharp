using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I am World!");
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name + ".");
            Console.ReadLine();
        }
    }
}
