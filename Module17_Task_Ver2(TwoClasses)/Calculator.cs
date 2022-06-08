using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Task_Ver2_TwoClasses_
{
    /// <summary>
    /// Class for calculations
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Class decide how to calculate
        /// </summary>
        /// <param name="acc"></param>
        public static void Calculate(ICalculator acc)
        {
            acc.Calculate();
        }

    }
}
