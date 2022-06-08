using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Task_Ver2_TwoClasses_
{
    /// <summary>
    /// Class realize interface
    /// </summary>
    class SalaryAccount: ICalculator
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        /// <summary>
        /// Constructor of account
        /// </summary>
        /// <param name="balance"> Balance of account </param>
        public SalaryAccount(double balance)
        {
            Balance = balance;
            Interest = 0;
        }

        /// <summary>
        /// Method calculates account's interest
        /// </summary>
        public void Calculate()
        {
            Interest = Balance * 0.5;
        }
    }
}
