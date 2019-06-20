using System;
using System.Collections.Generic;

namespace DebtSnowball
{
    [Serializable]
    public class Debt
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public double IntrestRate { get; set; }
        public double Payment { get; set; }
        public double OriginalBalance { get; set; }

        public DateTime FirstPaymentDate { get; set; }

        public bool Enabled { get; set; }

        public List<ExtraPayment> ExtraPayments;

        public Debt()
        {
            ExtraPayments = new List<ExtraPayment>();
        }

        public Debt(string name, double balance, double intrestrate, double payment, DateTime firstPaymentDate)
        {
            ExtraPayments = new List<ExtraPayment>();
            Name = name;
            Balance = balance;
            OriginalBalance = balance;
            IntrestRate = intrestrate;
            Payment = payment;
            FirstPaymentDate = firstPaymentDate;
            Enabled = true;
        }

        public static double CalculateInterest(double interestRate, double balance, int year, int month)
        {
            double ret = 0;

            double newrate = interestRate * 0.01;
            double periodicrate = (newrate / 365);

            ret = balance * periodicrate * DateTime.DaysInMonth(year, month);

            return ret;
        }

        public static PaymentResult CalculateBalanceWithPayment(double interestRate, double payment, double balance, int year, int month)
        {
            PaymentResult ret = new PaymentResult();

            double newrate = interestRate * 0.01;
            double periodicrate = (newrate / 365);

            double interest = balance * periodicrate * DateTime.DaysInMonth(year, month);

            ret.Interest = interest;

            if (interest > payment)
            {
                throw new Exception("Debit of $" + balance.ToString() + " with a rate of " + interestRate.ToString() + "% has a payment that is too low to cover interest!");
            }

            double red = (payment - interest);

            if (red < balance)
            {
                ret.NewBalance = balance - red;
                ret.Principal = red;
            }
            else
            {
                ret.NewBalance = balance - interest;
                ret.Principal = red;
                ret.NewBalance = 0;
            }

            return ret;
        }

    }
}
