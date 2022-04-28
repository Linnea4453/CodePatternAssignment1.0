using Kennel.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Customer
{
    public class Customer : ICustomer
    {
     
        public List<IAnimal> Animals {get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public void SaveCustomer(ICustomer customer, List<ICustomer> customers)
        {
            customers.Add(customer);
        }

        public void CreateCustomer(List<ICustomer> customers)
        {
            ICustomer customer = Factory.CreateCustomer();
            customer.Id = Guid.NewGuid().ToString();
            customer.Name = "";

            Console.WriteLine("What's your name?");
            customer.Name = Console.ReadLine();


                    Console.WriteLine($" Welcome  {customer.Name}! ");
                    Console.WriteLine("You are now registreted as a new customer at our Kennel ");
                     customer.SaveCustomer(customer, customers);
                
            
        }

        public void GetCustomer(List<ICustomer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"CustomerName : {customer.Name}");
            }
        }

      
    }
}
