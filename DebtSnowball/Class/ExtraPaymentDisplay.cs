using System.ComponentModel;

namespace DebtSnowball
{
    public class ExtraPaymentDisplay
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        [DisplayName("Start Date")]
        public string StartDate { get; set; }
        [DisplayName("Stop Date")]
        public string StopDate { get; set; }
        ExtraPayment.Frequecy Recurring { get; set; }
        public bool Enabled { get; set; }
        public ExtraPaymentDisplay(ExtraPayment ep)
        {
            Name = ep.Name;
            Recurring = ep.Recurring;
            StartDate = ep.StartDate.ToShortDateString();
            Amount = ep.Amount.ToString("C2");
            Enabled = ep.Enabled;

            if (ep.IndefiniteStopDate)
            {
                StopDate = "Indefinite";
            }
            else
            {
                StopDate = ep.StopDate.ToShortDateString();
            }
        }
    }
}
