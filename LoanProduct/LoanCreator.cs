using System;

namespace LoanProduct;

public enum LOANTYPE
{
    HOME,
    PERSONAL
}

public abstract class LoanCreator
{
    public abstract ILoan FactoryMethod();
    public abstract LoanCreator Create(LOANTYPE loantype);

    public string PaymentFrequency()
    {
        var product = FactoryMethod();
        return product.PaymentFrequency();
    }

    public double PaymentAmount()
    {
        var product = FactoryMethod();
        return product.PaymentAmount();
    }
}

//public class HomeLoanCreator : LoanCreator
//{
//    public override ILoan FactoryMethod() => new HomeLoan();
//}

//public class PersonalLoanCreator : LoanCreator
//{
//    public override ILoan FactoryMethod() => new PersonalLoan();
//}

public class Creator : LoanCreator
{
    private ILoan _loan;

    public override LoanCreator Create(LOANTYPE loantype)
    {
        switch (loantype)
        {
            case LOANTYPE.HOME:
                _loan = new HomeLoan();
                break;
            case LOANTYPE.PERSONAL:
                _loan = new PersonalLoan();
                break;
            default:
                break;
        }

        return this;
    }

    public override ILoan FactoryMethod() => _loan;
}
