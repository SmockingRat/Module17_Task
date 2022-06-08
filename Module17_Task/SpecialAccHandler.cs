using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Task
{
    /// <summary>
    /// Class reailizes abstract class to calculate salary accounts
    /// </summary>
    class SpecialAccHandler : AccountHandler
    {
        /// <summary>
        /// Method calculates "Зарплатные" accounts
        /// </summary>
        /// <param name="account"> Account object </param>
        public override void Handler(Account account)
        {
            if (account.Type == "Зарплатный")
            {
                account.Interest = account.Balance * 0.5;
            }
            else if (Successor != null)
            {
                Successor.Handler(account);
            }
        }
    }
}
