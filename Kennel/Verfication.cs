using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    public class Verfication
    {
        public static bool VerifyUserName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > 2  )
            
                return false;
            
            else
            
                return true;
            
        }
    }
}
