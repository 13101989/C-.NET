using System;
namespace OOP_assignment
{
    class Program
    {
        static void Main()
        {
            Customer andreea = new Customer("Andreea", "Blaga");
            CustomerPrivileged valentin = new CustomerPrivileged("Valentin", "Bogdan");
            CustomerEmployee petre = new CustomerEmployee("Petre", "Bumbac");

            Console.WriteLine($"No of customers within bank: {Bank.NoOfCustomers}");
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");

            //andreea.DepositMoney = 100;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");
            //valentin.DepositMoney = 999;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");

            //andreea.WithdrawMoney = 5100;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");
            //valentin.WithdrawMoney = 5200;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");
            //valentin.WithdrawMoney = 5200;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");
            //andreea.DepositMoney = 1000000;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");

            //petre.WithdrawMoney = 5200;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");
            //petre.DepositMoney = 1000000;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");
            //petre.WithdrawMoney = 500;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");
            //petre.DepositMoney = 100000;
            //Console.WriteLine($"Bank balance: {Bank.BankBalance} RON");

            //andreea.ReturnRepaymentSchedule(300000, 12);
            //valentin.ReturnRepaymentSchedule(300000, 12);
            //petre.ReturnRepaymentSchedule(300000, 12);

            //andreea.GrossSalary = 3000;
            //andreea.ChecktMonthlyPensionDeposit();
            //valentin.GrossSalary = 3000;
            //valentin.ChecktMonthlyPensionDeposit();
            //petre.GrossSalary = 3000;
            //petre.ChecktMonthlyPensionDeposit();

        }
    }
}

