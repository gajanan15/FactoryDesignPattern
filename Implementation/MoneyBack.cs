using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Implementation
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "Money Back";
        }
        public string GetCreditLimit()
        {
            return "50000";
        }
        public string GetAnnualCharge()
        {
            return "500";
        }
    }
}
