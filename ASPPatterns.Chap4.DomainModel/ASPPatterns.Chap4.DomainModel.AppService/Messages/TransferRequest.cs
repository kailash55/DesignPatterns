using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.AppService.Messages
{
    public class TransferRequest
    {
        public Guid FromAccountNo { get; set; }
        public Guid ToAccountNo { get; set; }
        public decimal Amount { get; set; }
    }
}
