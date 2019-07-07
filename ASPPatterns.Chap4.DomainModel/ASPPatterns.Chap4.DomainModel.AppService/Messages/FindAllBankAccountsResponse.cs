using ASPPatterns.Chap4.DomainModel.AppService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.AppService.Messages
{
    public class FindAllBankAccountsResponse : ResponseBase
    {
        public IList<BankAccountView> BankAccounts { get; set; }
    }
}
