using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Task
{
    /// <summary>
    /// Class realize abstract class to calculate simple accounts
    /// </summary>
    class SimpleAccHandler : AccountHandler
    {
        /// <summary>
        /// Method calculates "обычные" accounts
        /// </summary>
        /// <param name="account"> Account object </param>
        public override void Handler(Account account)
        {
            if(account.Type == "Обычный")
            {
                account.Interest = account.Balance * 0.4;
                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;
                if (account.Balance < 50000)
                    account.Interest -= account.Balance * 0.4;
            }
            else if(Successor != null)
            {
                Successor.Handler(account);
            }
        }
    }
}
