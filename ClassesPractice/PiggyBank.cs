using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesPractice
{
    class PiggyBank
    {
        private float currentBalance = 3.50F;

        public void deposit(float net)
        {
            Console.WriteLine("Its payday");
            net = currentBalance + net;
            currentBalance = net;
        }
        public float withdraw(float net)
        {
            net = currentBalance - net;
            currentBalance = net;
            return currentBalance;
        }
        public float balance()
        {
            return currentBalance;
        }
    }
}
