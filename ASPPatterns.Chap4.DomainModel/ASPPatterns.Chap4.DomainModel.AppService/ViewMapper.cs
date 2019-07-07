using ASPPatterns.Chap4.DomainModel.AppService.ViewModels;
using ASPPatterns.Chap4.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.AppService
{
    public class ViewMapper
    {
        public static TransactionView CreateTransactionViewFrom(Transaction transaction)
        {
            TransactionView TransactionView = new TransactionView();
            TransactionView.Withdrawl = transaction.Withdrawl.ToString("C");
            TransactionView.Deposit = transaction.Deposit.ToString("C");
            TransactionView.Reference = transaction.Reference;
            TransactionView.Date = transaction.Date;

            return TransactionView;
        }

        public static BankAccountView CreateBankAccountViewFrom(BankAccount bankAccount)
        {
            BankAccountView BankAccountView = new BankAccountView();
            BankAccountView.AccountNo = bankAccount.AccountNo;
            BankAccountView.Balance = bankAccount.Balance.ToString("C");
            BankAccountView.CustomerRef = bankAccount.CustomerRef;
            BankAccountView.Transaction = new List<TransactionView>();

            return BankAccountView;
        }
    }
}
