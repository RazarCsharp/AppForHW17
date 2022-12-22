using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using AppForModule17.ChoseProfiles;

namespace AppForModule17
{
    public static class Calculator
    {
        /// <summary>
        /// Метод для расчета процентной ставки
        /// </summary>
        /// <param name="account"></param>
        public static void CalculateInterest(Account account)
        {
            Console.WriteLine(account.Interest);
        }

    }
}
