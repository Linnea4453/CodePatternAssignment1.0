using Kennel.Animal;
using Kennel.Customer;
using Kennel.ExtraService;
using Kennel.Menu;
using Kennel.Recepit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    public static class Factory // Tillverkar alla nya
    {
        public static ICustomer CreateCustomer()
        {
            return new Customer.Customer();
        }

        public static IMenuManager CreateMenu()
        {
            return new MenuManager();
        }

        public static IAnimal CreateAnimal()
        {
            return new Animal.Animal();
        }

        public static ISetPriceAndName SetPriceAndName()
        {
            return new SetPriceAndName();
        }
        public static IStandardService CreateStandardService()
        {
            return new StandardService();
        }
        public static IWash CreateWash()
        {
            return new Wash();
        }

        public static IClawCutting CreateClawCutting()
        {
            return new ClawCutting();
        }

        public static IReceipt CreateReceipt()
        {
            return new Receipt.Receipt();
        }
    }
}
