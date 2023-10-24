using System;
using System.IO;

namespace Tymakov_8
{
    enum Type
    {
        Now,
        Sber
    }
    internal class Program
    {
        public static bool ImplementsIFormattableIs(object input)
        {
            if (input is IFormattable)
            {
                return true;
            }

            return false;
        }
        public static bool ImplementsIFormattableAs(object input)
        {
            if (input as IFormattable == null)
            {
                return false;
            }

            return true;
        }
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
            Console.WriteLine();


            Console.WriteLine("Упр 8.2");
            Console.WriteLine("Отразить строку");
            string input = Console.ReadLine();
            string reversed = Reverse.Reversed(input);
            Console.WriteLine(reversed);
            Console.WriteLine();


            Console.WriteLine("Упр 8.4");
            Console.WriteLine("Реализовать метод System.IFormattable.");
            BankAccount ex_account = new BankAccount();
            if (ImplementsIFormattableIs(ex_account))
            {
                Console.WriteLine("Объект реализует интерфейс System.IFormattable");
            }
            else
            {
                Console.WriteLine("Объект не реализует интерфейс System.IFormattable");
            }
            if (ImplementsIFormattableAs(ex_account))
            {
                Console.WriteLine("Объект реализует интерфейс System.IFormattable");
            }
            else
            {
                Console.WriteLine("Объект не реализует интерфейс System.IFormattable");
            }



            Console.WriteLine("Для завершения работы нажммите любую клавишу");
            Console.ReadKey();
        }
    }
}
