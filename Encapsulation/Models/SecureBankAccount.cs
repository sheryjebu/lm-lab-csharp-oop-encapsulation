// See https://aka.ms/new-console-template for more information
namespace Encapsulation.Models
{
    public class SecureBankAccount
    {
        private readonly string _accountNumber;
        private const int REWARD_AMOUNT = 50;
        private int _accountBalance;

        public SecureBankAccount(string accountNumber)
        {
            _accountNumber = accountNumber;
            _accountBalance = 0;
        }

        public void DepositAmount(int amount)
        {
            _accountBalance += amount;
            AddReward();
        }

        public void DisplayAccountBalanceDetails()
        {
            Console.WriteLine($"Your account balance is {_accountBalance}");
        }

        public void DebitAmount(int amount)
        {
            _accountBalance -= amount;
        }

        private void AddReward()
        {
            _accountBalance += REWARD_AMOUNT;
        }
    }
}

