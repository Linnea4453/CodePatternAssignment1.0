using Kennel.Animal;
using Kennel.Customer;
using Kennel.Menu;
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
    }
}
