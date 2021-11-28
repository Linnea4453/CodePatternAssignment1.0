using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Recepit
{
    public interface IReceipt
    {
        public int BasciCost { get; set; }
        public int TotalCost { get; set; }
    }
}
