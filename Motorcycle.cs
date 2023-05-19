using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal enum eLicenseType { A1, A2, AA, B1 }

    internal abstract class Motorcycle : Vehicle
    {
        eLicenseType m_LicenseType;
        uint m_EngineCapcity;
    }
}
