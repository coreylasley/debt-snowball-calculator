using System.ComponentModel;

namespace DebtSnowball
{
    public class DebtPaymentDisplay
    {
        public string Date { get; set; }
        public string Name { get; set; }
        public string Payment { get; set; }
        [DisplayName("Snowball")]
        public string ExtraPaid { get; set; }
        public string Principal { get; set; }
        public string Intrest { get; set; }
        public string Balance { get; set; }
        [DisplayName("Total Interest Paid")]
        public string TotalInterestPaid { get; set; }
        [DisplayName("Total Balance")]
        public string TotalBalance { get; set; }
        [DisplayName("Total Monthly Principal")]
        public string TotalMonthlyPrincipal { get; set; }
        [DisplayName("Total Monthly Interest")]
        public string TotalMonthlyInterest { get; set; }

        public DebtPaymentDisplay(DebtPayment dp)
        {
            Date = dp.Date;
            Name = dp.Name;
            Payment = dp.Payment.ToString("C2");
            ExtraPaid = dp.ExtraPaid.ToString("C2");
            Principal = dp.Principal.ToString("C2");
            Intrest = dp.Intrest.ToString("C2");
            Balance = dp.Balance.ToString("C2");
            TotalInterestPaid = dp.TotalInterestPaid.ToString("C2");
            TotalBalance = dp.TotalBalance.ToString("C2");
            TotalMonthlyPrincipal = dp.TotalMonthlyPrincipal.ToString("C2");
            TotalMonthlyInterest = dp.TotalMonthlyInterest.ToString("C2");
        }
    }
}
