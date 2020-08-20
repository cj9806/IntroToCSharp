using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            for (int i = 10; i > 0; i--)
            {
                data[i-1] = i;
                Console.WriteLine(data[i-1]);
            }
            
            //create 4 numbers and store in an array
            EasyChoice ec = new EasyChoice();
            int[] custArr = new int[4];
            for(int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Please select a number to go into the array, current spot: {i+1}");
                custArr[i] = (ec.ForceInt());
            }
            Console.WriteLine();
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine(custArr[i-1]);
            }
            
        }   
    }
}
