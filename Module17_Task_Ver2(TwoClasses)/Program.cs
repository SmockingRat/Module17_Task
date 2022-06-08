using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Task_Ver2_TwoClasses_
{
    /// <summary>
    /// Я не совсем понял, как именно надо было решать, поэтому первой моей мыслью было подобие цепочки обязанностей. Собственно, это второе 
    /// решение, в котором под каждый тип аккаунта создается новый класс. Однако мне так и не пришло в голову, как в таком случае избаиться от проверки на класс.
    /// Была мысль - создать отдельный обработчик, который через свитч будет отправлять полученные данные на создание класса. Но тогда я не понимаю, как корректно обращатся к классу.
    /// В итоге тут под каждый аккаунт создаётся обьект разного класса, которые наследуют метод от интерфейса. Правда тогда отпадает смысл в классе Calculator, его можно просто выпилить, 
    /// ведь у каждого класса есть свой метод Calculate
    /// 
    /// Entry class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry class
        /// </summary>
        /// <param name="args"> Entry parameter </param>
        static void Main(string[] args)
        {
            SimpleAccount Vasiliy = new SimpleAccount(3000000);
            SalaryAccount Anya = new SalaryAccount(400000);

            Calculator.Calculate(Anya);
            Calculator.Calculate(Vasiliy);

            Console.WriteLine($"Ставка аккаунта Ани - {Anya.Interest}");
            Console.WriteLine($"Ставка аккаунта Васи - {Vasiliy.Interest}");

            Console.ReadLine();
        }
    }
}
