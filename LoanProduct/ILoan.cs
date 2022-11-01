using System;

namespace LoanProduct;

public interface ILoan
{
    string PaymentFrequency();
    double PaymentAmount();
}
