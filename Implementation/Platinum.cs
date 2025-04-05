using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern.Implementation
{
    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public string GetCreditLimit()
        {
            return "75000";
        }
        public string GetAnnualCharge()
        {
            return "750";
        }
    }
}
