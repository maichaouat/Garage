using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private float m_PercentageOfEnrgyLeft;
        private Wheel[] m_Wheels = null;
        private uint m_MaxTierPressure;
        private Engine m_Engine;

        internal abstract void InflatWheel(float i_AirPressureToAdd);
        internal abstract void ChargeUp(float i_AmountToCharge, ePowerType ePowerType);
    }
}
