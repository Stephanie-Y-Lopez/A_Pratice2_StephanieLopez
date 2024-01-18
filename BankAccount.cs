using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Pratice2_StephanieLopez
{
    internal class BankAccount
    {
        //Part 2 of project
        //Fields
        private string _accountNumber;
        private string _customerName;
        private double _balance;

        //Constructor
        public BankAccount(string accountNumber, string customerName, double balance)
        {
            _accountNumber = accountNumber;
            _customerName = customerName;
            _balance = balance;
        }

        //Properties
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        //Methods 
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
        }

        //Override
        public override string ToString()
        {
            return $"{_accountNumber} - {_customerName} - Current Balance: {_balance.ToString("c")}";
        }
    }
}
