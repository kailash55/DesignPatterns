using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.Model
{
    public class BankAccount
    {
        private decimal _balance;
        private Guid _accountNo;
        private string _customerRef;
        private IList<Transaction> _transactions;

        public BankAccount() : this(Guid.NewGuid(), 0, new List<Transaction>(), "")
        {
            _transactions.Add(new Transaction(0m, 0m, "account created", DateTime.Now));
        }

        public BankAccount(Guid id, decimal balance, IList<Transaction> transactions, string customerRef)
        {
            this._accountNo = id;
            this._balance = balance;
            this._transactions = transactions;
            this._customerRef = customerRef;
        }

        public Guid AccountNo
        {
            get { return _accountNo; }
            internal set { _accountNo = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string CustomerRef
        {
            get { return _customerRef; }
            set { _customerRef = value; }
        }

        public bool CanWithdraw(decimal amount)
        {
            return (Balance >= amount);
        }

        public void Withdraw(decimal amount, string reference)
        {
            if(CanWithdraw(amount))
            {
                Balance -= amount;
                _transactions.Add(new Transaction(0m, amount, reference, DateTime.Now));
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }

        public void Deposit(decimal amount, string reference)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, 0m, reference, DateTime.Now));
        }

        public IList<Transaction> GetTransactions()
        {
            return _transactions;
        }
    }
}
