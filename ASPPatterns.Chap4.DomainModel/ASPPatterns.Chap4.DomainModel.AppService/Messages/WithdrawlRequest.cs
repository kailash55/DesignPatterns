using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.AppService.Messages
{
    public class WithdrawlRequest 
    {
        public Guid AccountNo { get; set; }
        public decimal Amount { get; set; }
    }
}
