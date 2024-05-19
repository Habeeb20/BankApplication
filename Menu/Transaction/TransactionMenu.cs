using DTO.Command;
using Entity;
using ProjectOOP.Services.Interfaces;
using Services.Implementations;
using Services.Interfaces;
using System.Collections.Generic;

namespace Menu.Transaction
{
    public class TransactionMenu
    {
        ITransactionService _transactionService;
        public TransactionMenu()
        {
            _transactionService = new TransactionService();
        }
        public void CreateTransaction(Guid customerId)
        {
            Console.WriteLine(
                "1. Airtime\n2. Data\n3. Transfer\n4. Deposit"
                );
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid Input");
            }
            switch (option)
            {
                case 1:
                    CreateAirTimeTransaction(customerId);
                    break;
                case 2:
                    CreateDataTransaction(customerId);
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        public void CreateAirTimeTransaction(Guid customerId)
        {
            Console.WriteLine("1. N100\n2. N200\n3. N500\n4. N1000\n5. N2000");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid Input");
                Console.ResetColor();
            }
            var transactionRequest = new CreateTransactionRequest();
            switch (option)
            {
                case 1:
                    transactionRequest.Amount = 100;
                    _transactionService.Create(transactionRequest, customerId);
                    break;
                case 2:
                    transactionRequest.Amount = 200;
                    break;
                case 3:
                    transactionRequest.Amount = 500;
                    break;
                case 4:
                    transactionRequest.Amount = 1000;
                    break;
                case 5:
                    transactionRequest.Amount = 2000;
                    break;
                default:
                    break;
            }
            var transaction = _transactionService.Create(transactionRequest, customerId);
            Console.WriteLine(transaction.Item2);
        }
        public void CreateDataTransaction(Guid customerId)
        {
            Console.WriteLine("1. N50 for 25MB\n2. N100 for 75MB\n3. N200 for 200MB\n4. N500 for 750MB\n5. N1000 for 1.5GB\n6. N2000 for 3.5GB");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid Input");
                Console.ResetColor();
            }
            var transactionRequest = new CreateTransactionRequest();
            switch (option)
            {
                case 1:
                    transactionRequest.Amount = 25;
                    break;
                case 2:
                    transactionRequest.Amount = 75;
                    break;
                case 3:
                    transactionRequest.Amount = 200;
                    break;
                case 4:
                    transactionRequest.Amount = 750;
                    break;
                case 5:
                    transactionRequest.Amount = 1.5M;
                    break;
                default:
                    break;
            }
            var transaction =  _transactionService.Create(transactionRequest, customerId);
            System.Console.WriteLine(transaction.Item2);
        }

        public void CreateTransferTransaction(Guid customerId)
        {
            System.Console.WriteLine("Amount:  ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Reciever Account");
            string recieverAcctNum = Console.ReadLine();
            System.Console.WriteLine("your pin is required");
        }
        public void CheckTransactionHistory(Guid customerId)
        {
            var transactions = _transactionService.GetAll(customerId);
            Console.WriteLine(".................");
            if(transactions is not null)
            {
                foreach(var transaction in transactions)
                {
                    Console.WriteLine($"\nAmount: {transaction.Amount}");
                    Console.WriteLine($"\nTransaction Type: {transaction.TransactionType.ToString()}");
                    Console.WriteLine($"\nTransactionDate: {transaction.TransactionDate}");
                    Console.WriteLine($"\nDescription: {transaction.Description}");
                    Console.WriteLine($"\nReceiver: {transaction.ReceiverAcctNum}");


                }

         
            }
            Console.WriteLine("...............");

        }

        internal void CreateTransaction(object customer)
        {
            throw new NotImplementedException();
        }
    }
}