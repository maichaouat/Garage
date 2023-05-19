using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricEngine : Engine
    {
        private float m_RemainingBatteryTime;
        private float m_MaximumBatteryTime;

        internal override void ChargeUp(float i_ChargingBatteryTime, ePowerType i_PowerType = ePowerType.Electric)
        {
            ///NOTE: need to use here the ValueOutOfRangeException
        }
    }
}
