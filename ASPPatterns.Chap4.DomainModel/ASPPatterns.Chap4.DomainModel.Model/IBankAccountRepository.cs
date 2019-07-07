using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.Model
{
    public interface IBankAccountRepository
    {
        void Add(BankAccount bankAccount);
        void Save(BankAccount bankAccount);
        IEnumerable<BankAccount> FindAll();
        BankAccount FindBy(Guid accountId);
    }
}
