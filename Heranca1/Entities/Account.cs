using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca1.Entities
{
    class Acount
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public double Balance { get; set; }

        public Acount()
        {
        }

        public Acount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
