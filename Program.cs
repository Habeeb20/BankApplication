using Menu;
using Repository.Implementations;

internal class Program
{
    private static void Main(string[] args)
    {
        if(!File.Exists(ProjectOOP.ApplicationConstants.FileConstants.CUSTOMERFILE))
        {
            File.Create(Path.Combine(Directory.GetCurrentDirectory(),ProjectOOP.ApplicationConstants.FileConstants.CUSTOMERFILE));
        }

        if(!File.Exists(ProjectOOP.ApplicationConstants.FileConstants.ACCOUNTFILE))
        {
            File.Create(Path.Combine(Directory.GetCurrentDirectory(),ProjectOOP.ApplicationConstants.FileConstants.ACCOUNTFILE));
        }

        if(!File.Exists(ProjectOOP.ApplicationConstants.FileConstants.TRANSACTION))
        {
            File.Create(Path.Combine(Directory.GetCurrentDirectory(),ProjectOOP.ApplicationConstants.FileConstants.TRANSACTION));
        }
        Console.ResetColor();
        CustomerRepository.LoadInitialData();
        AccountRepository.LoadInitialAcctData();
        TransactionRepository.LoadInitialTransactionData();
        var main = new Main();
        main.LandingMenu();
    }
}