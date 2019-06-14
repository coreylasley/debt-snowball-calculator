using System;
using System.Collections.Generic;

namespace DebtSnowball
{
    public class AccumulatorCollection
    {
        public List<Accumulator> Accumulators;

        public AccumulatorCollection()
        {
            Accumulators = new List<Accumulator>();
        }

        public double GetMonthAccumulation(string Date)
        {
            double ret = 0;

            foreach (Accumulator a in Accumulators)
            {
                if (a.Date == Date)
                {
                    ret = a.Amount;
                    break;
                }
            }

            return Math.Round(ret, 2);
        }

        public void AddTo(string Date, double Amount)
        {
            bool found = false;

            foreach (Accumulator a in Accumulators)
            {
                if (a.Date == Date)
                {
                    a.Amount += Amount;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Accumulator ac = new Accumulator();
                ac.Date = Date;
                ac.Amount = Amount;
                Accumulators.Add(ac);
            }
        }
    }
}
