using System;

namespace DebtSnowball
{
    [Serializable]
    public class DebtPayment
    {
        public string Date { get; set; }
        public string Name { get; set; }
        public double Payment { get; set; }
        public double Principal { get; set; }
        public double Intrest { get; set; }
        public double Balance { get; set; }
        public double TotalInterestPaid { get; set; }
        public double TotalBalance { get; set; }
        public double TotalMonthlyPrincipal { get; set; }
        public double TotalMonthlyInterest { get; set; }

        public DebtPayment()
        {
        }
    }
}
