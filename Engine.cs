using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal enum ePowerType { Soler, Octan95, Octan96, Octan98, Electric }

    internal abstract class Engine
    {
        internal abstract void ChargeUp(float i_AmountToCharge, ePowerType ePowerType);
    }
}
