using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManangement
{
   public class Loan
    {
        private Account Id;
        private string Status;
        private string LoanType;
        private DateTime DateOfLoan;
        private double Amount;

        public Loan(Account id, string status, string loanType, DateTime dateOfLoan, double amount)
        {
            this.Id = id;
            this.Status = status;
            this.LoanType = loanType;
            this.DateOfLoan = dateOfLoan;
            this.Amount = amount;
        }

        public Account GetId()
        {
            return Id;
        }

        public void setId(Account id)
        {
            this.Id = id;
        }

        public string GetStatus()
        {
            return Status;
        }

        public void SetStatus(string status)
        {
            this.Status = status;
        }
        public string GetLoanType()
        {
            return LoanType;
        }

        public void SetLoanType(string loanType)
        {
            this.LoanType = loanType;
        }
        public DateTime GetDateOfLoan()
        {
            return DateOfLoan;
        }

        public void SetDateOfLoan(DateTime dateOfLoan)
        {
            this.DateOfLoan = dateOfLoan;
        }
        public double GetAmount()
        {
            return Amount;
        }

        public void SetAmount(double amount)
        {
            this.Amount = amount;
        }
    }
}
