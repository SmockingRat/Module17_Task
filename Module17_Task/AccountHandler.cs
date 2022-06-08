using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Task
{
    /// <summary>
    /// Abstract class, which will handle account parameters
    /// </summary>
    abstract class AccountHandler
    {
        /// <summary>
        /// Parameter describe success of calculations
        /// </summary>
        public AccountHandler Successor { get; set; }

        /// <summary>
        /// Abstract method, which handle calculations
        /// </summary>
        /// <param name="account"></param>
        public abstract void Handler(Account account);
    }
}
