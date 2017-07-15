using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcct
{
    class Account
    {
        //fields

        protected int accountNumber;
        protected double accountBalance;
        protected string accountType;

        //properties

        public int AcccountNumber { get; }
        public double AccountBalance { get; }
        public string AccountType { get; }

        //constructors

        public  Account()
        {
            //default constructor
        }

        public Account( int acctNumConst, double acctBalConst, string acctTypeConst)
        {
            this.accountNumber = acctNumConst;
            this.accountBalance = acctBalConst;
            this.accountType = acctTypeConst;
        }
        public Account(double acctBalConst)
        {            
            this.accountBalance = acctBalConst;           
        }
        //methods

        public virtual int AccountNumberMethod()
        {
            int acctNum = accountNumber;
            return acctNum;
        }

        public virtual double AccountBalanceMethod()
        {
            
            //double acctBal = accountBalance;
            Console.WriteLine(accountBalance);
            return accountBalance;
        }

        public virtual string AccountTypeMethod()
        {
            string acctType = accountType;
            return acctType;
        }
    }
}
