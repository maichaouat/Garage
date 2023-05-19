using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
   
    internal class CombustionEngine : Engine
    {
        private ePowerType m_FuelType;
        private float m_CurrentFuelAmount;
        private float m_FuelTankCapacity;

        internal override void ChargeUp(float i_AmountToRefuel, ePowerType i_FuelType)
        {
            ///NOTE: need to use here the ValueOutOfRangeException and ArgumentException
        }
    }
}
