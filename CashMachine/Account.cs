using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Account
    {
        private int balance;
        private String pin, lastTranscation;

        public Account(String p, int b) 
        {
            pin = p;
            balance = b;
        }
        public Boolean checkPin(String p)
        {
            if (pin.Equals(p))
            {
                return true;
            }
            else 
            {
             return false;
            }
        }
        public int getBalance() 
        {
            return balance;
        }
        public Boolean withDraw(int amount) 
        {
            if (amount > balance)
            {
                return false;
            }
            else 
            {
                lastTranscation = "Balance was; " + balance + " amount withdrawn " + amount;
                balance -= amount; //balance = balance - amount;  
                
                return true;
            }
        }
        public String getLastTranscation() 
        {
            if (lastTranscation != null)// != means not equal to 
            {
                return lastTranscation;
            }
            else 
            {
                return "No transaction";
            }
        }
    }
}
