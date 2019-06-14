using System;
using System.Collections.Generic;

namespace DebtSnowball
{
    [Serializable]
    public class Plan
    {
        public List<Debt> Debts { get; set; }
        public List<ExtraPayment> ExtraPayments { get; set; }

        public Plan()
        {
            Debts = new List<Debt>();
            ExtraPayments = new List<ExtraPayment>();
        }
    }
}
