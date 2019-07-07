using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.Model
{
    public class Transaction
    {
        public decimal Deposit { get; set; }
        public decimal Withdrawl { get; set; }
        public string Reference { get; set; }
        public DateTime Date { get; set; }

        public Transaction(decimal deposit, decimal withdrawl, string reference, DateTime date)
        {
            this.Deposit = deposit;
            this.Withdrawl = withdrawl;
            this.Reference = reference;
            this.Date = date;
        }
    }
}
