using Kennel.Animal;
using Kennel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Menu
{
    public class MenuManager : IMenuManager
    {
        public void PopulateMenu()
        {
            Console.WriteLine("Welcome to this Kennel");
            Console.WriteLine("Press 1 to register a new customer");
            Console.WriteLine("Press 2 to register a new animal");
            Console.WriteLine("Press 3 view alla customers");
            Console.WriteLine("Press 4 to view all animals");
            Console.WriteLine("Press 5 to show witch animal belongs to witch customer");
            Console.WriteLine("Press 6 to Check in Animal");
            Console.WriteLine("Press 7 to Check out Animal");
            Console.WriteLine("Press 8 to view all checkd in animals");
            Console.WriteLine("Press 9 to purchase animal service");
        }

        public void MenuActions()
        {
          

            ICustomer customer = Factory.CreateCustomer();
            IAnimal animal = Factory.CreateAnimal();

            List<ICustomer> customers = new List<ICustomer>();
            List<IAnimal> animals = new List<IAnimal>();

            customers = DataManager.CreateCustomerList();
            animals = DataManager.CreateAnimalList();


            var IsRunning = true;
            Console.Clear();
            while (IsRunning)
            {
                PopulateMenu();
                var options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        Console.Clear();
                        customer.CreateCustomer(customers); // Funkar
                        break;
                    case "2":
                        Console.Clear();
                        animal.CreateAnimal(animals, customers); // Funkar
                        break;
                    case "3":
                        Console.Clear();
                        customer.GetCustomer(customers); // Funkar
                        break;
                    case "4":
                        Console.Clear();
                        animal.GetAnimals(animals); // Funkar
                        break;
                    case "5":
                        Console.Clear();
                        animal.GetAnimalsWithOwner(animals);
                        break;
                    case "6":
                        Console.Clear();
                        animal.CheckInAnimal(animals, animal); // Funkar
                        break;
                    case "7":
                        Console.Clear();
                        animal.CheckOutAnimal(animals, animal); // Funkar
                        break;
                    case "8":
                        Console.Clear();
                        animal.GetCheckedInAnimals(animals ); // Funkar
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Unaccepteble! Try again");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}


