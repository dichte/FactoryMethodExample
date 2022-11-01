using System;

namespace LoanProduct;

public class PersonalLoan : ILoan
{
    public string PaymentFrequency() => "Monthly";
    public double PaymentAmount() => 100.1;
}
