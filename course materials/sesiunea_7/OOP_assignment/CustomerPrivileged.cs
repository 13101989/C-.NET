using System;
namespace OOP_assignment
{
    public class CustomerPrivileged : Customer
    {
        public override float MortgageAnnualFee { get; set; } = 5.1F;

        public CustomerPrivileged(string firstname, string lastname) : base(firstname, lastname)
        {}

        public override void ReturnRepaymentSchedule(float MortgageSum, float MortgagePeriod)
        {
            float MonthlyPay;
            float MonthlyPayWithFee;
            float MortgageSumWithFee;

            MortgageSum = 0.99f * MortgageSum;
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
    }
}

