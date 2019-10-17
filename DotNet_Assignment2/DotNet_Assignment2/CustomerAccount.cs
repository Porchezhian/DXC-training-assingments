using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignment2
{
    class CustomerAccount
    { 
        private int account_number;
        private string account_holder;
        private int customer_id;
        private int account_balance;
        private int opening_balance;
        private List<int> deposits = new List<int>();
        private List<int> withdrawals = new List<int>();

        public CustomerAccount()
        {
            this.account_number = 0;
            this.account_holder = "";
            this.customer_id = 0;
            this.account_balance = 0;
            this.opening_balance = 0;
        }

        public CustomerAccount(int account_number, string account_holder, int customer_id, int account_balance, int opening_balance)
        {
            this.account_number = account_number;
            this.account_holder = account_holder;
            this.customer_id = customer_id;
            this.account_balance = account_balance;
            this.opening_balance = opening_balance;
        }

        public int getCustomerId()
        {
            return this.customer_id;
        }

        public void deposit(int amount)
        {
            this.account_balance = this.account_balance + amount;
            this.deposits.Add(amount); 
            Console.WriteLine("\nDeposited Rs.{0} in your account", amount);
            Console.WriteLine("Your account balance is Rs.{0}", this.account_balance);
        }

        public void withdraw(int amount)
        {
            if (this.account_balance - 500 < amount)
            {
                Console.WriteLine("\nCannot perform the requested operation...\nWithdraw request amount is greater than your maximum withdrawable amount");
            }
            else
            {
                this.account_balance = this.account_balance - amount;
                this.withdrawals.Add(amount);
                Console.WriteLine("\nWithdrew Rs.{0} from your account", amount);
                Console.WriteLine("Your account balance is Rs.{0}", this.account_balance);
            }
        }

        public void showDetails()
        {
            Console.WriteLine("\nAccount Holder Name: {0}\nAccount Number: {1}\nAccount Balance: Rs.{2}\nOpening Balance: Rs.{3}", 
                this.account_holder, this.account_number, this.account_balance, this.opening_balance);
        }

        public void showDeposits()
        {
            if (this.deposits.Count() != 0)
            {
                Console.WriteLine("\n");
                foreach (var item in deposits)
                {
                    Console.WriteLine("-Rs.{0}\n", item);
                }
            }
            else
                Console.WriteLine("\nNot done any deposits yet");
        }

        public void showWithdrawals()
        {
            if (this.withdrawals.Count() != 0)
            {
                Console.WriteLine("\n");
                foreach (var item in withdrawals)
                {
                    Console.WriteLine("-Rs.{0}\n", item);
                }
            }
            else
                Console.WriteLine("\nNot done any withdrawals yet");
        }
    }
}
