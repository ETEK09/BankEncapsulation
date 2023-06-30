namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tysonsAccount = new BankAccount();
            
            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            tysonsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {tysonsAccount.GetBalance()}.");

        }
    }
}
