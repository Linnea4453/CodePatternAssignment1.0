using Kennel.Customer;
using Kennel.Menu;
using System;
using System.Collections.Generic;

namespace Kennel
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMenuManager manager = Factory.CreateMenu();
            manager.MenuActions();
        }    
    }
}    
    


