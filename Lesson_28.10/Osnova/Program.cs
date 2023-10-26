using System;


namespace Osnova
{
    enum WorkingDepartments
    {
        system,
        worker,
        boss,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employer Semyon = new Employer("Семен", "Генеральный директор", WorkingDepartments.boss);

            Employer Rashid = new Employer("Рашид", "Финансовый директор", WorkingDepartments.boss, Semyon);
            Employer Lucas = new Employer("Лукас", "Начальник бухгалтерии", WorkingDepartments.boss, Rashid);

            Employer OIlham = new Employer("О Ильхам", "Директор по автоматизации", WorkingDepartments.boss, Semyon);
            Employer Orkady = new Employer("Оркадий", "Начальник отдела информационных технологий", WorkingDepartments.boss, OIlham);
            Employer Volodya = new Employer("Володя", "Зам. начальника отдела информационных технологий", WorkingDepartments.boss, Orkady);

            Employer Ilshat = new Employer("Ильшат", "Начальник отдела системщиков", WorkingDepartments.boss, Orkady, Volodya);
            Employer Ivanych = new Employer("Иваныч", "Зам. начальника отдела системщиков", WorkingDepartments.boss, Ilshat);

            Employer Ilya = new Employer("Илья", "Работник отдела системщиков", WorkingDepartments.system, Ivanych);
            Employer Vitya = new Employer("Витя", "Работник отдела системщиков", WorkingDepartments.system, Ivanych);
            Employer Zhenya = new Employer("Женя", "Работник отдела системщиков", WorkingDepartments.system, Ivanych);

            Employer Sergey = new Employer("Сергей", "Начальник отдела разработчиков", WorkingDepartments.boss, Orkady, Volodya);
            Employer Laysan = new Employer("Ляйсан", "Зам. начальника отдела разработчиков", WorkingDepartments.boss, Sergey);

            Employer Marat = new Employer("Марат", "Работник отдела разработчиков", WorkingDepartments.worker, Laysan);
            Employer Dina = new Employer("Дина", "Работник отдела разработчиков", WorkingDepartments.worker, Laysan);
            Employer Ildar = new Employer("Ильдар", "Работник отдела разработчиков", WorkingDepartments.worker, Laysan);
            Employer Anton = new Employer("Антон", "Работник отдела разработчиков", WorkingDepartments.worker, Laysan);


            Task task1 = new Task("Подгготовить отчёт", WorkingDepartments.boss);
            Task task2 = new Task("Заняться разработкой нового приложения", WorkingDepartments.worker);
            Task task3 = new Task("Настроить локальную сеть", WorkingDepartments.system);
            Task task4 = new Task("Проверить отчёт бухгалтерии", WorkingDepartments.boss);

            Ilya.AssignmentOfTask(task1, Ivanych);
            Console.WriteLine();
            OIlham.AssignmentOfTask(task2, Vitya);
            Console.WriteLine();
            Sergey.AssignmentOfTask(task3, Anton);
            Console.WriteLine();
            Sergey.AssignmentOfTask(task1, Orkady);
            Console.ReadKey();
        }
    }
}
