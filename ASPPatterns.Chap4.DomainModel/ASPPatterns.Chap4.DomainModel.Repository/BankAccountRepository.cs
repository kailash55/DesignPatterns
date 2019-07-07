using ASPPatterns.Chap4.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.Repository
{
    public class BankAccountRepository : IBankAccountRepository
    {
        public void Add(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankAccount> FindAll()
        {
            throw new NotImplementedException();
        }

        public BankAccount FindBy(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public void Save(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }
    }
}
