using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManangement
{
    public class OverDraft
    {
        private int Id;
        private double Amount;
        private Account Account;
        private DateTime Date;

        public OverDraft(double amount, int  id, DateTime date)
        {
            this.Amount = amount;
            this.Id = id;
            this.Date = date;

        }
        public double GetAmount()
        {
            return Amount;
        }
        public void SetAmount(double amount)
        {
            this.Amount = amount;
        }

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            this.Id = id;
        }

        public DateTime GetDate()
        {
            return Date;
        }

        public void SetDate(DateTime date)
        {
            this.Date = date;
        }
    }
}
