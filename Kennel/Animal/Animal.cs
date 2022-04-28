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
    public class Animal : IAnimal
    {
        public Animal()
        {
            //    ExtraServices = new List<IExtraService>();
        }

        public bool CheckedIn { get; set; } = false;
        public string Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public ICustomer Owner { get; set; }

        public IStandardService StandardService { get; set; }

        public IWash Wash { get; set; }

        public IClawCutting ClawCutting { get; set; }

        public void CheckInAnimal(List<IAnimal> animals, IAnimal animal)
        {
            Console.WriteLine("Name of the animal you would lika to check in?");
            var name = Console.ReadLine();

            if (animals.Any(animal => animal.Name == name))
            {
                animal.Name = name;
                Console.WriteLine($"Check in {animal.Name}?| yes | no |");
                var checkingIn = Console.ReadLine();
                while ((checkingIn != "yes") && (checkingIn != "no"))
                {
                    Console.WriteLine("Please try again");
                    checkingIn = Console.ReadLine();
                }

                if (checkingIn.ToLower() == "yes")
                {
                    var variabel = animals.FirstOrDefault(n => n.Name == name);
                    if (variabel != null)
                    {
                        if (variabel.CheckedIn == true)
                        {
                            Console.WriteLine($"{animal.Name} are checked in now");
                        }
                        else
                        {
                            variabel.CheckedIn = true;
                            Console.WriteLine($"{animal.Name} are not checked in");
                        }
                    }
                }
                else if (checkingIn.ToLower() == "no")
                {

                    var variabel = animals.FirstOrDefault(n => n.Name == name);

                    if (variabel.CheckedIn == true)
                    {
                        Console.WriteLine($"{animal.Name} are NOT checked in");
                    }
                    else
                    {
                        variabel.CheckedIn = true;
                        Console.WriteLine("No CheckIn");
                    }
                }

                else
                {
                    Console.WriteLine("Cant find your animale");
                }
            }
        }

        public void CheckOutAnimal(List<IAnimal> animals, IAnimal animal, IReceipt receipt, IStandardService standardService, IClawCutting clawCutting, IWash wash)
        {
            Console.WriteLine("Please, enter the animals name");
            var name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Please, try again");
                name = Console.ReadLine();
            }

            if (animals.Any(animal => animal.Name == name))
            {
                animal.Name = name;
                Console.WriteLine($"Get the animal {animal.Name}? | yes | no |");
                var checkedIn = Console.ReadLine();

                while ((checkedIn != "yes") && (checkedIn != "no"))
                {
                    Console.WriteLine("Please, try again");
                    checkedIn = Console.ReadLine();
                }

                if (checkedIn.ToLower() == "yes") // Right way?
                {
                    var pet = animals.FirstOrDefault(n => n.Name == name);
                    if (pet.CheckedIn == true)
                    {
                        if (pet != null)
                        {
                            pet.CheckedIn = false;
                            Console.WriteLine($"{animal.Name} Animal ar now Checked Out");

                            receipt.ShowReceipt(standardService, clawCutting, wash, animals, animal);

                        }

                        // Måste lösa ett kvitto på något sätt

                        else
                        {

                            Console.WriteLine("No Animanl with that name are here, sorry");
                        }
                    }
                }
                else if (checkedIn.ToLower() == "no")
                {

                    var pets = animals.FirstOrDefault(n => n.Name == name);

                    if (pets.CheckedIn == true)
                    {
                        Console.WriteLine($"{animal.Name} is already here");
                    }
                    else
                    {
                        Console.WriteLine("No animal are checked in");
                    }
                }

                else
                {
                    Console.WriteLine("Cant find your animale");
                }
            }
        }

        public void CreateAnimal(List<IAnimal> animals, List<ICustomer> customers)
        {
            IAnimal animal = Factory.CreateAnimal();
            ICustomer customer = Factory.CreateCustomer();
            IWash wash = Factory.CreateWash();
            IClawCutting clawCutting = Factory.CreateClawCutting();

            animal.Name = "";
            animal.CheckedIn = false;
            animal.ClawCutting = clawCutting;
            clawCutting.Status = false;
            animal.Wash = wash;
            wash.Status = false;
            animal.Owner = customer;

            Console.WriteLine("Whats the name of the animal?");
            animal.Name = Console.ReadLine();

            //Whileloopa om du hinner

            Console.WriteLine("Whats the name of this animals owners?");
            var ownerName = Console.ReadLine();

            customer = customers.FirstOrDefault(n => n.Name == ownerName);

            if (customer != null)
            {
                animal.Owner = customer;
                animal.SaveAnimal(animal, animals);
                Console.WriteLine($"{animal.Name} are now registrated as a animal in this system");
            }
        }

        public void GetAnimals(List<IAnimal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animalname : {animal.Name}");
            }
        }



        public void GetAnimalsWithOwner(List<IAnimal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"This animal {animal.Name} belongs t {animal.Owner.Name} ");
            }
        }

        public void GetCheckedInAnimals(List<IAnimal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.CheckedIn == true)
                {
                    Console.WriteLine($"Animal {animal.Name} is checked in ");
                }

                else if (animal.CheckedIn != true && false)
                {
                    Console.WriteLine("There´are no animals checked in at the moment");
                }
            };
        }

        public void SaveAnimal(IAnimal animal, List<IAnimal> animals)
        {
            animals.Add(animal);
        }

        public void SetExtraServices(List<IAnimal> animals, IAnimal animal)
        {
            Console.WriteLine("Write the name of animal:");
            var name = Console.ReadLine();

            while (name == "")
            {
                Console.Write("Error, please try again");
                name = Console.ReadLine();
            }

            animal = animals.FirstOrDefault(x => x.Name == name);

            if (animal != null)
            {
                if (animal.CheckedIn == true)
                {
                    Console.WriteLine($"Do you want to add clawcutting {animal.Name}? | yes | no |");
                    var _cut = Console.ReadLine();

                    while ((_cut != "yes") && (_cut != "no"))
                    {
                        Console.Write("Error, please try again");
                        _cut = Console.ReadLine();
                    }

                    
                   if (_cut.ToLower() == "yes")
                    {
                        var search = animals.FirstOrDefault(x => x.Name == name);
                        if (search.ClawCutting.Status == false)
                        {
                            if (search != null)
                            {
                                search.ClawCutting.Status = true;
                                Console.WriteLine($"Clawcutting are now added to {animal.Name}");
                            }
                        }
                    }

                    Console.WriteLine($"Do you want to wash {animal.Name}? | yes | no | ");
                    var _wash = Console.ReadLine();

                    while ((_wash != "yes") && (_wash != "no"))
                    {
                        Console.Write("Error, please try again");
                        _wash = Console.ReadLine();
                    }

                    if (_wash.ToLower() == "yes")
                    {
                        var search = animals.FirstOrDefault(x => x.Name == name);
                        if (search.Wash.Status == false)
                        {
                            if (search != null) search.Wash.Status = true;
                            Console.Write($"Washing are now added to {animal.Name}");
                        }
                    }
                }
                else
                {
                    Console.Write("Sorry, no animal with that name are checked in");
                }
            }
            else
            {
                Console.Write("Sorry, we got no animal with that name in our system");
            }
        }
    }
}

