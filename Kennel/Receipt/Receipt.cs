using Kennel.Animal;
using Kennel.ExtraService;
using Kennel.Recepit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Receipt
{
    public class Receipt : IReceipt
    {
        public IStandardService StandardService { get; set; }
        public IWash Wash { get; set; }

        public IClawCutting ClawCutting { get; set; }
        public decimal TotalCost { get; set; }

        ISetPriceAndName setServicePriceAndName = Factory.SetPriceAndName();

        public void ShowReceipt(IStandardService standardService, IClawCutting clawCutting, IWash wash, List<IAnimal> animals, IAnimal animal)
        {
            setServicePriceAndName.SetPrices(standardService, wash, clawCutting);
            setServicePriceAndName.SetName(standardService, wash, clawCutting);
            Console.WriteLine("Write in the animals name for a receipt:");
            var name = Console.ReadLine();

            if (animals.Any(animal => animal.Name == name))
            {
                animal.Name = name;
                Console.Write($"Print receipt {animal.Name}? (yes/no) ");
                var _kvitto = Console.ReadLine();

                if (_kvitto.ToLower() == "yes")
                {
                    var search = animals.FirstOrDefault(x => x.Name == name);
                    if (search.CheckedIn == false)
                    {
                        if (search != null)
                        {
                            if (search.Wash.Status == true && search.ClawCutting.Status == true)
                            {
                                var totalCost = standardService.Price + wash.Price + clawCutting.Price;
                                Console.WriteLine($"Extra Services: {standardService.Name}, {clawCutting.Name}, {wash.Name}, Total Cost: {totalCost}SEk");
                            }
                            else if (search.Wash.Status == true && search.ClawCutting.Status == false)
                            {
                                var totalCost = standardService.Price + wash.Price;
                                Console.WriteLine($"Extra Services: {standardService.Name}, {wash.Name}, Total Cost::{totalCost}SEK");
                            }
                            else if (search.Wash.Status == false && search.ClawCutting.Status == true)
                            {
                                var totalCost = standardService.Price + clawCutting.Price;
                                Console.WriteLine($"Extra Services: {standardService.Name}, {clawCutting.Name}, Total Cost:: {totalCost}SEK");
                            }
                            else if (search.Wash.Status == false && search.ClawCutting.Status == false)
                            {
                                var totalCost = standardService.Price;
                                Console.WriteLine($"Extra Services: {standardService.Name}, Total Cost:: {totalCost}SEK");
                            }
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
            }
        }
    }
}
