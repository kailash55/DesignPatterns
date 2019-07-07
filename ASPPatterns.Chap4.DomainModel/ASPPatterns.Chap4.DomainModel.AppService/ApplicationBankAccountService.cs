using ASPPatterns.Chap4.DomainModel.AppService.Messages;
using ASPPatterns.Chap4.DomainModel.Model;
using ASPPatterns.Chap4.DomainModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.AppService
{
    public class ApplicationBankAccountService
    {
        private BankAccountService _bankAccountService;
        private IBankAccountRepository _bankRepository;

        public ApplicationBankAccountService():
            this(new BankAccountRepository(),
                new BankAccountService(new BankAccountRepository()))
        {
                
        }

        public ApplicationBankAccountService(IBankAccountRepository repository, BankAccountService bankAccountService)
        {
            _bankRepository = repository;
            _bankAccountService = bankAccountService;
        }

        public BankAccountCreateResponse CreateBankAccount(BankAccountCreateRequest bankAccountCreateRequest)
        {
            BankAccountCreateResponse bankAccountCreateResponse = new BankAccountCreateResponse();

            BankAccount bankAccount = new BankAccount();
            bankAccount.CustomerRef = bankAccountCreateRequest.CustomerRef;

            _bankRepository.Add(bankAccount);

            return bankAccountCreateResponse;
        }
    }
}
