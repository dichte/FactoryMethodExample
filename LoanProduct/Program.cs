// See https://aka.ms/new-console-template for more information
using LoanProduct;

HomeLoan homeLoan = new();
Console.WriteLine($"Home Loan Payment Amout: {homeLoan.PaymentAmount()} | Home Loan Payment Frequency: {homeLoan.PaymentFrequency()}");

PersonalLoan personalLoan = new();
Console.WriteLine($"Personal Loan Payment Amout: {personalLoan.PaymentAmount()} | Personal Loan Payment Frequency: {personalLoan.PaymentFrequency()}");


var creator = new Creator();

var hl = creator.Create(LOANTYPE.HOME);
Console.WriteLine($"Home Loan Payment Amout: {hl.PaymentAmount()} | Home Loan Payment Frequency: {hl.PaymentFrequency()}");

var pl = creator.Create(LOANTYPE.PERSONAL);
Console.WriteLine($"Personal Loan Payment Amout: {pl.PaymentAmount()} | Personal Loan Payment Frequency: {pl.PaymentFrequency()}");


