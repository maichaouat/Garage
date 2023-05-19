using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal enum eColor { White, Black, Yellow, Red }
    internal enum eNumOfDoors { Two = 2, Three, Four, Five }

    internal abstract class Car : Vehicle
    {
        private eColor m_Color;
        private eNumOfDoors m_NumOfDoors;
    }   
}
