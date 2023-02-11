using System;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_assignment
{
    public class Customer : Bank, IMortgageLoan, IPension2ndPillar
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public decimal ClientBalance { get; set; } = 5000;
        public virtual float MortgageAnnualFee { get; set; } = 5.8F;
        public double GrossSalary { get; set; }

        public Customer(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            NoOfCustomers = NoOfCustomers + 1;
        }

        public int DepositMoney
        {
            set
            {
                if (value > 100000)
                {
                    Console.WriteLine($"Transaction canceled! {FirstName} the maximum deposit amount per transaction allowed is {100000} RON.");
                }
                else
                {
                    ClientBalance += value;
                    BankBalance += value;
                    Console.WriteLine($"Transaction succeded! {FirstName} you have made a deposit of {value} RON. Your current balance is now {ClientBalance} RON");
                }
            }
        }

        public int WithdrawMoney
        {
            set
            {
                if (ClientBalance >= value)
                {
                    ClientBalance -= value;
                    BankBalance -= value;
                    Console.WriteLine($"Transaction succeded! {FirstName} you have withdrawn {value} RON. Funds available after this transaction: {ClientBalance} RON");
                }
                else
                {
                    Console.WriteLine($"Transaction canceled! {FirstName} you do not have enough funds. Funds currently available in your account: {ClientBalance}");
                }
            }
        }

        public virtual void ReturnRepaymentSchedule(float MortgageSum, float MortgagePeriod)
        {
            float MonthlyPay;
            float MonthlyPayWithFee;
            float MortgageSumWithFee;

            MonthlyPay = MortgageSum / MortgagePeriod;
            MonthlyPayWithFee = MonthlyPay + MonthlyPay * MortgageAnnualFee / 100 * MortgagePeriod / 20;
            MortgageSumWithFee = MonthlyPayWithFee * MortgagePeriod;

            Console.WriteLine($"\n------------------------------------------ {FirstName} {LastName} -----------------------------------------\n");
            Console.WriteLine($"Mortgage to pay: {MortgageSum} RON / Credit period: {MortgagePeriod} months;\n");
            Console.WriteLine($"Total mortgage to return (including fees) : {(int)Math.Round(MortgageSumWithFee)} RON\n");
            Console.WriteLine("------------------------------------------- Scheduler ----------------------------------------------\n");

            for (int i = 1; i <= MortgagePeriod; i++)
            {
                MortgageSum -= MonthlyPay;
                Console.WriteLine($"Rent no {i} --> Mortgage left to pay: {(int)Math.Round(MortgageSum)} RON / Period remaining: {MortgagePeriod - i} months / Month rent: {(int)Math.Round(MonthlyPayWithFee)} RON\n");
            }
        }

        public virtual void ChecktMonthlyPensionDeposit()
        {
            if (GrossSalary > 0)
            {
                double MonthlyPensionDeposit = 0.0375 * GrossSalary;
                Console.WriteLine($"\n{FirstName} your monthly deposit to the private 2nd pillar pension account is: {MonthlyPensionDeposit} RON\n");
            }
            else
            {
                Console.WriteLine($"\n{FirstName} your need first to have a salary in order for us to be able to deposit money in your pension account.\n");
            }
        }
    }
}

