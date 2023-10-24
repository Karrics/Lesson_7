using System;

namespace Tymakov_8
{
    internal class BankAccount
    {
        private static int nextAccountNumber = 1; // Статическая переменная для генерации номера счета
        private int accountNumber; // Номер счета
        private decimal balance; // Баланс
        private Type accountType; // Тип счета

        // Конструктор класса, генерирующий уникальный номер счета
        public BankAccount()
        {
            accountNumber = nextAccountNumber;
            nextAccountNumber++;
            balance = 0;
            accountType = Type.Now;
        }
        public void SetAccountData(int number, decimal Balance, Type type)
        {
            accountNumber = number;
            balance = Balance;
            accountType = type;
        }

        // Метод для доступа к номеру счета
        public int GetAccountNumber()
        {
            return accountNumber;
        }

        // Метод для доступа к балансу
        public decimal GetBalance()
        {
            return balance;
        }

        // Метод для доступа к типу счета
        public Type GetAccountType()
        {
            return accountType;
        }

        // Метод для установки значения баланса
        public void SetBalance(decimal newBalance)
        {
            balance = newBalance;
        }

        // Метод для вывода информации о счете
        public void PrintAccountInfo()
        {
            Console.WriteLine("Номер счета: " + accountNumber);
            Console.WriteLine("Баланс: " + balance);
            Console.WriteLine("Тип счета: " + accountType);
        }

        public bool TakeOn(decimal canTakeOn)
        {
            if (canTakeOn >= 0)
            {
                balance += canTakeOn;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Withdraw(decimal amount)
        {
            if (0 <= amount && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public static void Transfer(BankAccount fromAccount, BankAccount toAccount, decimal amount)
        {
            bool canWithdraw = fromAccount.Withdraw(amount);

            if (canWithdraw)
            {
                toAccount.Deposit(amount);
                Console.WriteLine("\nУспешно переведено " + amount + " рублей со счета "
                    + fromAccount.GetAccountNumber() + " на счет " + toAccount.GetAccountNumber() + ".");
            }
            else
            {
                Console.WriteLine("\nОшибка при переводе. Недостаточно средств на счете " + fromAccount.GetAccountNumber() + ".");
            }
        }
    }
}
