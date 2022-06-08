using System;
using System.Diagnostics;

namespace Module17_Task
{
    /// <summary>
    /// Мне показалось удобным использовать подобие Chain of Responsibility. Причина в том, что нам требуется обрабатывать показатели аакаунта по его типу
    /// Но аккаунты создаются одного класса, тип аккаунта хранится в нем самом, пользователь не создает свой аккаунт заранее Премиальынм или стандартным
    /// 
    /// Есть вторая версия, в которой для каждого типа аккаунта создается свой класс со своим методом. Я принял решение показать оба способа
    /// 
    /// Собственно
    /// Entry class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry method
        /// </summary>
        /// <param name="args"> Entry parameter </param>
        static void Main(string[] args)
        { 
            Account Vasiliy = new Account("Обычный", 3000000);
            Account Anya = new Account("Зарплатный", 400000);

            CalculationHandler.Calculate(Anya);
            Console.WriteLine($"Ставка аккаунта Ани - {Anya.Interest}");

            CalculationHandler.Calculate(Vasiliy);
            Console.WriteLine($"Ставка аккаунта Васи - {Vasiliy.Interest}");

            Console.ReadLine();
        }
    }
}
