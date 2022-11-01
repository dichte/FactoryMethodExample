using System;

namespace LoanProduct;

public class HomeLoan : ILoan
{
    public string PaymentFrequency() => "Fortnightly";
    public double PaymentAmount() => 50.5;
}
