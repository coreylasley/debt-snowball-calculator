using System;

namespace DebtSnowball
{
    [Serializable]
    public class PaymentResult
    {
        public double Interest { get; set; }
        public double Principal { get; set; }
        public double NewBalance { get; set; }

        public PaymentResult()
        {
        }
    }
}
