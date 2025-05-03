using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard = new MoneyBackFactory().CreateProduct();    
            if(creditCard != null)
            {
                Console.WriteLine("Card Type: " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit: " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge: " + creditCard.GetAnnualCharge());
                Console.WriteLine("test demo test");
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }

            creditCard = new TitaniumFactory().CreateProduct();
            if(creditCard != null)
            {
                Console.WriteLine("Card Type: " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit: " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge: " + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }

            Console.ReadLine();
        }
    }
}
