using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Implementation
{
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public string GetCreditLimit()
        {
            return "100000";
        }
        public string GetAnnualCharge()
        {
            return "1000";
        }
    }
}
