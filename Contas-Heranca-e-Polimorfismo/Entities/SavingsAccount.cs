using System;
using System.Collections.Generic;
using System.Text;

namespace Contas_Heranca_e_Polimorfismo.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public override void Withdraw(double amount)
        {
            // Balance -= amount;  Saque sem taxa
            base.Withdraw(amount);  // Saque com taxa original de R$ 5.0 + R$ 2.0
            Balance -= 2.0;
        }
        
    }
}
