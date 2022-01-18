using Contas_Heranca_e_Polimorfismo.Entities;
using System;

namespace Contas_Heranca_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500.0);
            BusinessAccount bacc = new BusinessAccount(2001, "Maria", 0.0, 500.0);

            // UPCASTING --> Conversão de subclasse para superclasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(2003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(3001, "Anna", 500.0, 0.01);

            // DOWNCASTING --> Conversão de superclasse para subclasse

            BusinessAccount acc4 = (BusinessAccount)acc2; // --> Preciso fazer a conversão
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; --> Tipos incompativeis. Da erro

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // outra forma de fazer o casting
                acc5.Loan(100.0);
                System.Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                System.Console.WriteLine("Update!");
            }

            acc.Withdraw(10.0);
            acc3.Withdraw(10.0);
            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc3.Balance);
        }

        
    }
}
