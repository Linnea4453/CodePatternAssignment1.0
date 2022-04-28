using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.ExtraService
{
   public class SetPriceAndName : ISetPriceAndName
    {
        public void SetPrices(IStandardService standardService, IWash wash, IClawCutting clawCutting)
        {
            standardService.Price = 1000;
            wash.Price = 250;
            clawCutting.Price = 150;
        }

        public void SetName(IStandardService standardService, IWash wash, IClawCutting clawCutting)
        {
            standardService.Name = "Daycare";
            wash.Name = "Washing";
            clawCutting.Name = "Clawcutting";
        }
    }
}
