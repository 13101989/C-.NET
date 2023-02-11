using System;
namespace OOP_assignment
{
    interface IMortgageLoan
    {
        float MortgageAnnualFee { get; set; }
        void ReturnRepaymentSchedule(float MortgageSum, float MortgagePeriod);
    }
}

