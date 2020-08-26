using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ZombieArenaPractice
{
    class QualityOfLife
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
        public string ForceString(string validString)
        {
            string userInput = Console.ReadLine();
            bool validChoice = false;
            while (!validChoice)
            {
                if (userInput == validString)
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("please enter yoour choice");
                    userInput = Console.ReadLine();
                }
                
            }
            return userInput;
        }
    }
}