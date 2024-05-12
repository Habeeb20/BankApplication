using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.Command;
using ProjectOOP.Dto.Query;

namespace ProjectOOP.Services.Interfaces
{
    public interface ITransactionService
    {
          (TransactionDto, string) Create(CreateTransactionRequest request, Guid customerId);
        IEnumerable<object> GetAll(Guid customerId);
    }
}