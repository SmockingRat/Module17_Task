using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Task
{
    /// <summary>
    /// Class is deciding, how to calculate parameters
    /// </summary>
    class CalculationHandler
    {
        /// <summary>
        /// Method sends object on calculation
        /// </summary>
        /// <param name="account"> Parameter contains Account </param>
        public static void Calculate(Account account)
        {
            AccountHandler spec = new SpecialAccHandler();
            AccountHandler simple = new SimpleAccHandler();
            simple.Successor = spec;
            simple.Handler(account);
        }
    }
}
