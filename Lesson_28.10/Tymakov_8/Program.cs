using System;
using System.Collections.Generic;
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



            Console.WriteLine("Дз 8.2");
            Console.WriteLine("Списки песен");
            List<Song> songs = new List<Song>();

            // Создание и заполнение первой песни
            Song song1 = new Song();
            song1.SetName("Lost in the echo");
            song1.SetAuthor("Linkin Park");
            songs.Add(song1);

            // Создание и заполнение второй песни
            Song song2 = new Song();
            song2.SetName("Skyfall");
            song2.SetAuthor("Adele");
            songs.Add(song2);

            // Создание и заполнение третьей песни
            Song song3 = new Song();
            song3.SetName("Bring Me To Life");
            song3.SetAuthor("Evanescense");
            songs.Add(song3);

            // Создание и заполнение четвертой песни
            Song song4 = new Song();
            song4.SetName("How You Like That");
            song4.SetAuthor("BLACKPINK");
            songs.Add(song4);

            // Вывод информации о каждой песне
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Title());
            }

            Console.WriteLine();
            // Сравнение первой и второй песни
            if (song1.Equals(song2))
            {
                Console.WriteLine("Первая песня совпадает со второй песней");
            }
            else
            {
                Console.WriteLine("Первая песня не совпадает со второй песней");
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения работы нажммите любую клавишу");
            Console.ReadKey();
        }
    }
}
