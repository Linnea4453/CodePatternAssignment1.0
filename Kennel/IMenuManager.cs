using Kennel.Animal;
using Kennel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Menu
{
    public interface IMenuManager
    {
        public void PopulateMenu();
        public void MenuActions();
    }
}
