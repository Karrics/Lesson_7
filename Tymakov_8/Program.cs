using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_8
{
    enum Type
    {
        Now,
        Sber
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Упр 8.1");
            Console.WriteLine("Перевод с одного счёта на другой");
            BankAccount account1 = new BankAccount();
            account1.SetBalance(1000.50m);

            BankAccount account2 = new BankAccount();
            account2.SetBalance(5000.75m);

            Console.WriteLine("Информация о счете 1:");
            account1.PrintAccountInfo();

            Console.WriteLine();

            Console.WriteLine("Информация о счете 2:");
            account2.PrintAccountInfo();

            // Перевод денег со счета 1 на счет 2
            decimal transferAmount;
            Console.WriteLine();
            Console.WriteLine("Введите сумму, которую хотите перевести с одного счёта на другой");
            bool succes = decimal.TryParse(Console.ReadLine(), out transferAmount);
            if (succes)
            {
                BankAccount.Transfer(account1, account2, transferAmount);

                Console.WriteLine("\nИнформация о счете 1 после перевода:");
                account1.PrintAccountInfo();

                Console.WriteLine();

                Console.WriteLine("Информация о счете 2 после перевода:");
                account2.PrintAccountInfo();
            }
            else
            {
                Console.WriteLine("Неверно введено число");
            }
            Console.ReadKey();
        }
    }
}
