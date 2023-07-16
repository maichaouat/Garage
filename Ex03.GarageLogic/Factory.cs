using System;
using System.Collections.Generic;


namespace Ex03.GarageLogic
{
    public static class Factory
    {
        private static CustomerDetails m_NewCostumerData;

        public static List<string> CreateNewVehicleFirstStep(List<string> i_BasicVehicleRequirements, string i_LicenseNumber)
        {
            List<string> v_AdditionalRequirements;
            string v_TypeOfVehicle;

            v_TypeOfVehicle = i_BasicVehicleRequirements[0];
            switch(v_TypeOfVehicle)
            {
                // $G$ CSS-999 (-3) If you use strings as conditions, You should use constants.
                // $G$ CSS-999 (-3) You should have used Enums.
                case "Car":
                    // $G$ DSN-001 (-10) Code duplication.
                    m_NewCostumerData = new CustomerDetails();
                    m_NewCostumerData.CustomerVehicle = new Car(i_BasicVehicleRequirements[1], i_LicenseNumber);
                    break;

                case "Motorcycle":
                    m_NewCostumerData = new CustomerDetails();
                    m_NewCostumerData.CustomerVehicle = new Motorcycle(i_BasicVehicleRequirements[1], i_LicenseNumber);
                    break;

                case "Truck":
                    m_NewCostumerData = new CustomerDetails();
                    m_NewCostumerData.CustomerVehicle = new Truck(i_BasicVehicleRequirements[1], i_LicenseNumber);
                    break;

                default:
                    throw new FormatException("Invalid vehicle type");
            }

            m_NewCostumerData.CustomerName = i_BasicVehicleRequirements[2];
            m_NewCostumerData.CustomerPhoneNumber = i_BasicVehicleRequirements[3];
            v_AdditionalRequirements = m_NewCostumerData.CustomerVehicle.AdditionalVehicleRequirements();
            return v_AdditionalRequirements;
        }
        public static void CreateNewVehicleSecondStep(List<string> v_AdditionalVehicleRequirements, GarageManager i_Garage)
        {
            m_NewCostumerData.CustomerVehicle.BuildTheAdditionalVehicleRequirements(v_AdditionalVehicleRequirements);
            i_Garage.InsertNewCustomerData(m_NewCostumerData);
        }
    }
}
