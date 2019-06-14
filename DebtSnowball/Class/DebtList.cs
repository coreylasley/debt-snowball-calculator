﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace DebtSnowball
{
    [Serializable]
    public class DebtList
    {
        public List<Debt> Debts { get; set; }

        public List<ExtraPayment> ExtraPayments { get; set; }

        public DebtList()
        {
            Debts = new List<Debt>();
        }

        public static DebtList Load(string Filename)
        {
            DebtList ret = new DebtList();
            if (File.Exists(Filename))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(DebtList));
                    TextReader tr = new StreamReader(Filename);
                    ret = (DebtList)serializer.Deserialize(tr);
                    tr.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return ret;
        }

        public static bool Save(DebtList dl, string Filename)
        {
            bool ret = false;
            try
            {
                Application.DoEvents();
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(dl.GetType());
                StreamWriter writer = new StreamWriter(Filename);
                x.Serialize(writer, dl);
                writer.Close();
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        private double GetTotalBalance()
        {
            double ret = 0;
            foreach (Debt d in Debts)
            {
                ret += d.Balance;
            }

            return ret;
        }

        public List<DebtPayment> ProcessPlan(bool Snowball, double extraPayment)
        {
            DateTime cur = DateTime.Now;
            List<DebtPayment> DebtPayments = new List<DebtPayment>();
                      

            double TotalIntrest = 0;

            foreach (Debt d in Debts)
            {
                d.Balance = d.OriginalBalance;
            }

            while (GetTotalBalance() > 0)
            {
                double curExtra = extraPayment;

                foreach(ExtraPayment ep in ExtraPayments.Where(x => x.Enabled == true))
                {
                    curExtra = curExtra + ep.IsItTimeToApply(cur.Month, cur.Year);
                }

                foreach (Debt d in Debts)
                {
                    if (d.Balance > 0 && d.Enabled)
                    {
                        double extra = 0;

                        if (d.Balance >= curExtra)
                        {
                            extra = curExtra;
                            curExtra = 0;
                        }
                        else
                        {
                            extra = d.Balance;
                            curExtra = curExtra - d.Balance;
                        }

                        PaymentResult pr = Debt.CalculateBalanceWithPayment(d.IntrestRate, d.Payment + extra, d.Balance, cur.Year, cur.Month);
                        d.Balance = pr.NewBalance;
                        TotalIntrest += pr.Interest;

                        DebtPayment dp = new DebtPayment();
                        dp.Intrest = Math.Round(pr.Interest, 2);
                        dp.Balance = Math.Round(pr.NewBalance, 2);
                        dp.Name = d.Name;
                        dp.Payment = Math.Round(d.Payment + extra, 2);
                        dp.Principal = Math.Round(pr.Principal, 2);
                        dp.TotalBalance = Math.Round(GetTotalBalance(), 2);
                        dp.TotalInterestPaid = Math.Round(TotalIntrest, 2);
                        dp.Date = cur.Month.ToString() + "/" + cur.Year.ToString();

                        DebtPayments.Add(dp);

                        if (Snowball)
                        {
                            if (d.Balance == 0)
                            {
                                Debt snowballTo = new Debt();
                                snowballTo.Balance = 9999999999;

                                foreach (Debt dm in Debts)
                                {
                                    if (dm.Enabled && dm.Balance < snowballTo.Balance && dm.Balance > 0) snowballTo = dm;
                                }

                                snowballTo.Payment += d.Payment;
                            }
                        }

                    }
                }

                cur = cur.AddMonths(1);

                if (cur.Year > 2050) break;
            }
            
            AccumulatorCollection acPrincipal = new AccumulatorCollection();
            AccumulatorCollection acInterest = new AccumulatorCollection();

            for (int x = 0; x < DebtPayments.Count; x++)
            {
                acInterest.AddTo(DebtPayments[x].Date, DebtPayments[x].Intrest);
                acPrincipal.AddTo(DebtPayments[x].Date, DebtPayments[x].Principal);
            }

            for (int x = 0; x < DebtPayments.Count; x++)
            {
                DebtPayments[x].TotalMonthlyInterest = acInterest.GetMonthAccumulation(DebtPayments[x].Date);
                DebtPayments[x].TotalMonthlyPrincipal = acPrincipal.GetMonthAccumulation(DebtPayments[x].Date);
            }
                        
            return DebtPayments;
        }

    }
}
