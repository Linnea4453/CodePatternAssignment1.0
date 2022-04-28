using Kennel.Customer;
using Kennel.ExtraService;
using Kennel.Recepit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Animal
{
    public interface IAnimal
    {
        public bool CheckedIn { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public ICustomer Owner{ get; set; }
        public IStandardService StandardService { get; set; }

        public IWash Wash { get; set; }

        public IClawCutting ClawCutting { get; set; }


        public void CreateAnimal(List<IAnimal> animals, List<ICustomer> customers);
        public void SaveAnimal(IAnimal animal, List<IAnimal> animals);
        public void GetAnimals(List<IAnimal> animals);
        public void GetAnimalsWithOwner(List<IAnimal> animals);
        public void CheckInAnimal(List<IAnimal> animals, IAnimal animal);
        public void GetCheckedInAnimals(List<IAnimal> animals);
        public void CheckOutAnimal(List<IAnimal> animals, IAnimal animal, IReceipt receipt, IStandardService standardService, IClawCutting clawCutting, IWash wash);
        public void SetExtraServices(List<IAnimal> animals, IAnimal animal);
        
    }
}
