using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var userBankAccount = new BankAccount();
            string userInput;
            
            do
            {
                Console.WriteLine("To get your balance type: balance To deposit money type: deposit To exit type: exit");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == "BALANCE")
                {
                    Console.WriteLine($"Your current balance is: {userBankAccount.GetBalance()}");
                }
                else if (userInput == "DEPOSIT")
                {
                    Console.WriteLine("Enter an amount you would like to deposit: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    userBankAccount.Deposit(depositAmount);
                }

            }while (userInput != "EXIT");
        }
    }
}
