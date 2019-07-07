using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.Model
{
    public class BankAccountService
    {
        private IBankAccountRepository _repository;

        public BankAccountService(IBankAccountRepository repository)
        {
            this._repository = repository;
        }

        public void Transfer(Guid accountNoTo, Guid accountNoFrom, decimal amount)
        {
            BankAccount bankAccountTo = _repository.FindBy(accountNoTo);
            BankAccount bankAccountFrom = _repository.FindBy(accountNoFrom);

            if(bankAccountFrom.CanWithdraw(amount))
            {
                bankAccountTo.Deposit(amount, "From Acc " + bankAccountFrom.CustomerRef);
                bankAccountFrom.Withdraw(amount, "Transfer to Acc " + bankAccountTo.CustomerRef);

                _repository.Save(bankAccountTo);
                _repository.Save(bankAccountFrom);
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }
    }
}
