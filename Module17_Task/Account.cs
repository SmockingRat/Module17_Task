using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Task
{
    /// <summary>
    /// Class describes account of Bank User
    /// </summary>
    class Account
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="type"> Parameter of class type - "Зарплатный" or "Обычный" </param>
        /// <param name="balance"></param>
        public Account(string type, double balance)
        {
            Type = type;
            Balance = balance;
            Interest = 0;
        }
    }
}
