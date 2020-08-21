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
                data[i - 1] = i;
                Console.WriteLine(data[i - 1]);
            }
            EasyChoice ec = new EasyChoice();
            //create 4 numbers and store in an array

            int[] custarr = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"please select a number to go into the array, current spot: {i + 1}");
                custarr[i] = (ec.ForceInt());
            }
            Console.WriteLine();
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine(custarr[i - 1]);
            }
            //enter 5 valuse, sort from smallest to largest
            int[] sortArry = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Please select a number to go into the second array, current spot: {i + 1}");
                sortArry[i] = ec.ForceInt();
            }
            Array.Sort(sortArry);
            Array.Reverse(sortArry);
            Console.WriteLine("the numbers you gave me in order from largest to smallest are");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sortArry[i]);
            }
            //create 2d array, output in grid
            int[,] gridMap = new int[3, 3];
            //{ {1,2,3},
            //  {4,5,6},
            //  {7,8,9} };
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    gridMap[i, j] = ((i * 3) + (j + 1));
                }
            }


            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine($"{gridMap[i,0]},{gridMap[i, 1]},{gridMap[i,2]}");
            }
            
        }
    }
}
