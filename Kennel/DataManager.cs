using Kennel.Animal;
using Kennel.Customer;
using Kennel.ExtraService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Menu
{
    public static class DataManager
    {
        public static List<ICustomer> CreateCustomerList()
        {
            var customers = new List<ICustomer>
            {
                new Customer.Customer {Id = Guid.NewGuid().ToString() , Name = "Linnea", Animals = new() { } },
                 new Customer.Customer {Id = Guid.NewGuid().ToString(), Name = "Jonas",  Animals = new() { } },
                  new Customer.Customer {Id = Guid.NewGuid().ToString(), Name = "Sara",  Animals = new() { } }
            };
            return customers;
        }

        public static List<IAnimal> CreateAnimalList()
        {
            var animals = new List<IAnimal>
            {
                new Animal.Animal {Owner = new Customer.Customer() {Name = "Linnea" } , Id = Guid.NewGuid().ToString(), Name = "Judith", OwnerId = 1, CheckedIn=true, ClawCutting = new ClawCutting() {Status = false }, Wash = new Wash() {Status = false }, StandardService = new StandardService() {Status = false }  },
                new Animal.Animal {Owner = new Customer.Customer() {Name = "Jonas" } , Id = Guid.NewGuid().ToString(), Name = "Astor", OwnerId= 2, CheckedIn=true, ClawCutting = new ClawCutting() {Status = false }, Wash = new Wash() {Status = false }, StandardService = new StandardService() {Status = false }   },
                new Animal.Animal {Owner = new Customer.Customer() {Name = "Sara" }, Id = Guid.NewGuid().ToString(), Name = "Peder", OwnerId= 3, CheckedIn=true,ClawCutting = new ClawCutting() {Status = false }, Wash = new Wash() {Status = false }, StandardService = new StandardService() {Status = false }   },
            };
            return animals;
        }
    }
}
