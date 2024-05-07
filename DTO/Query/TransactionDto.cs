using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Enums;

namespace ProjectOOP.Dto.Query
{
    public class TransactionDto
    {
      
        public decimal Amount;
        public DateTime TransactionDate;
        public string Description;
        public TransactionType TransactionType;
        public string ReceiverAcctNum;

   
    }
}