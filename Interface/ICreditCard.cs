using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Interface
{
    public interface ICreditCard
    {
        string GetCardType();
        string GetCreditLimit();
        string GetAnnualCharge();
    }
}
