using System;
namespace OOP_assignment
{
    public class CustomerEmployee : CustomerPrivileged
    {
        public CustomerEmployee(string firstname, string lastname) : base(firstname, lastname)
        { }

        public override void ChecktMonthlyPensionDeposit()
        {
            if (GrossSalary > 0)
            {
                double MonthlyPensionDeposit = 0.0475 * GrossSalary;
                Console.WriteLine($"\n{FirstName} your monthly deposit to the private 2nd pillar pension account is: {MonthlyPensionDeposit} RON\n");
            }
            else
            {
                Console.WriteLine($"\n{FirstName} your need first to have a salary in order for us to be able to deposit money in your pension account.\n");
            }
        }
    }
}

