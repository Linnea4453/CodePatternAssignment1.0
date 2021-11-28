using Kennel.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Customer
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Id { get; set; }


        public List<IAnimal> Animals { get; set; }
        public void CreateCustomer(List<ICustomer> customers);
        public void GetCustomer(List<ICustomer> customers);
        public void SaveCustomer(ICustomer customer, List<ICustomer> customers);

    }
}
