using System.ComponentModel;

namespace DebtSnowball
{
    public class DebtDisplay
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        [DisplayName("Intrest Rate")]
        public string IntrestRate { get; set; }
        public string Payment { get; set; }
        [DisplayName("Original Balance")]
        public string OriginalBalance { get; set; }
        public bool Enabled { get; set; }

        public DebtDisplay(Debt d)
        {
            Name = d.Name;
            Balance = d.Balance.ToString("C2");
            IntrestRate = d.IntrestRate.ToString() + "%";
            Payment = d.Payment.ToString("C2");
            OriginalBalance = d.OriginalBalance.ToString("C2");
            Enabled = d.Enabled; 
        }
    }
}
