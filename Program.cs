using System.Security.Principal;

namespace A_Pratice2_StephanieLopez
{
    internal class Program
    {
        // Stephanie Lopez
        // 1/18/24
        static void Main(string[] args)
        {
            //Car Class Instances!
            Car defaultCar = new Car();
            Car makeModelCar = new Car("Ram1500", "F-150");
            Car fullCar = new Car("Subaru", "Impreza", 2000, 5000);
            //I hope you dont mind I changed the displayed a little!

            Console.WriteLine("Car information:");
            Console.WriteLine(defaultCar.ToString());
            Console.WriteLine(makeModelCar.ToString());
            Console.WriteLine(fullCar.ToString());
            Console.WriteLine();

            //BankAccount Class Instances!
            BankAccount account = new BankAccount("12345", "Stephanie Lopez", 20);
            account.Deposit(500);
            account.Deposit(-15000);
            account.Withdraw(300);
            account.Withdraw(-500);

            Console.WriteLine("Bank Information:");
            Console.WriteLine(account);
            Console.WriteLine(account);
            Console.WriteLine(account);
            Console.WriteLine(account);
            Console.WriteLine(account);
        }
    }
}