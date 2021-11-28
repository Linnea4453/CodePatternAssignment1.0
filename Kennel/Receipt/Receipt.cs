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
        public int BasciCost { get; set; }
        public int TotalCost { get; set; }
    }
}
