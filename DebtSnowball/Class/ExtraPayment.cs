using System;

namespace DebtSnowball
{
    [Serializable]
    public class ExtraPayment
    {
        public enum Frequecy
        {
            Once,
            Daily,
            Weekly,
            Monthly,
            Annualy
        }

        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public bool IndefiniteStopDate { get; set; }
        public Frequecy Recurring { get; set; }
        public bool Enabled { get; set; }

        private int lastApplyMonth;
        private int lastApplyYear;

        public ExtraPayment()
        {
            Enabled = true;
            lastApplyMonth = 1;
            lastApplyYear = 1900;
        }

        /// <summary>
        /// Returns the amount to apply if it is time to apply it
        /// </summary>
        /// <param name="lastApplyMonth"></param>
        /// <param name="lastApplyYear"></param>
        /// <param name="currentMonth"></param>
        /// <param name="CurrentYear"></param>
        /// <returns></returns>
        public double IsItTimeToApply(int currentMonth, int CurrentYear)
        {
            double ret = 0;

            if (lastApplyYear == 1900)
            {
                lastApplyYear = StartDate.Year;
                lastApplyMonth = StartDate.Month;
            }

            DateTime dt = new DateTime(CurrentYear, currentMonth, 1);
            DateTime lt = new DateTime(lastApplyYear, lastApplyMonth, 1);
            if (lastApplyMonth <= currentMonth && lastApplyYear <= CurrentYear)
            {
                switch (Recurring)
                {
                    case Frequecy.Daily:
                        ret = Amount * DateTime.DaysInMonth(CurrentYear, currentMonth);
                        lastApplyMonth = currentMonth;
                        lastApplyYear = CurrentYear;
                        break;
                    case Frequecy.Weekly:
                        ret = Amount * (DateTime.DaysInMonth(CurrentYear, currentMonth) / 7);
                        lastApplyMonth = currentMonth;
                        lastApplyYear = CurrentYear;
                        break;
                    case Frequecy.Monthly:
                        ret = Amount;
                        lastApplyMonth = currentMonth;
                        lastApplyYear = CurrentYear;
                        break;
                    case Frequecy.Annualy:
                        if (lt.AddYears(1) == dt || lt == dt)
                        {
                            ret = Amount;
                            lastApplyMonth = currentMonth;
                            lastApplyYear = CurrentYear;
                        }
                        break;
                }
            }

            return ret;
            
        }


    }
}
