using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysPractice
{
    class EasyChoice
    {
        public int ForceInt()
        {
            int validInt = 0;
            bool validChoice = false;            
            while (!validChoice)
            {
                string keyInput = Console.ReadLine();
                if (int.TryParse(keyInput, out int b))
                {
                    validInt = int.Parse(keyInput);
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            return validInt;
        }
    }
}
