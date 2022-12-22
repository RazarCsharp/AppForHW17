using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppForModule17.ChoseProfiles;

namespace AppForModule17
{
    public class Account : IUsually, ISalary
    {
        /// <summary>
        /// тип учетной записи
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// баланс учетной записи
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// процентная ставка
        /// </summary>
        public double Interest { get; set; }

        /// <summary>
        /// методы дляпрофилей
        /// </summary>
        void IUsually.CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
        void ISalary.CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
