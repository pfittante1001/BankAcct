using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcct
{
    class Deposit : Account
    {
        //fields
        protected double depositAmount;

        //properties

        public double DepositAmount { get; }

        //constructors

        public Deposit()
        {
            //default constructor
        }

        public Deposit(double depAmtConst)
        {
            this.depositAmount = depAmtConst;
        }

        //Methods

        public override double AccountBalanceMethod()
        {
            Console.WriteLine(AccountBalance);
            return depositAmount + AccountBalance;
        }

        public void BalanceInformationMenuMethod()
        {
            double depositAmt = depositAmount;
            double acctBalAfter = base.AccountBalanceMethod();
            double acctBalBefore = base.AccountBalanceMethod();
            bool menuReturn = false;

            while (menuReturn == false)
            {
                Console.WriteLine();
                Console.WriteLine("\n\n***************************************************************\n\n");
                Console.WriteLine("              Balance Information");
                //Console.WriteLine("Account Balance before deposit: ${0}", acctBalBefore);
                Console.WriteLine("Deposit amount:                 ${0}", depositAmt);
                Console.WriteLine("Account Balance after deposit:  ${0}", acctBalAfter);
                Console.WriteLine("\n\n***************************************************************\n\n");

                Console.Write("\n\n\n\n\nPlease hit enter to return to the main menu");
                string menuReturnStr = Console.ReadLine();
                if (menuReturnStr == "")
                {
                    menuReturn = true;
                    Console.Clear();

                }

            }

        }
    }
}
