using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MTMeetPansheriya
{
    public class ElectricCar : Car
    {
        public double BatteryCapacity { get; set; }

        public ElectricCar(string id, string make, string model, int yearOfManufacture, string color, int numberOfDoors, int numberOfSeats, bool isConvertible, double batteryCapacity)
            : base(id, make, model, yearOfManufacture, color, numberOfDoors, numberOfSeats, isConvertible)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override decimal AnnualInsuranceCost()
        {
            decimal baseCost = YearOfManufacture >= 2010 ? 150 : 350;

            decimal doorsCost = NumOfDoors == 2 ? 50 :
                                NumOfDoors == 4 ? 100 :
                                NumOfDoors >= 5 ? 150 : 0;

            decimal seatsCost = NumOfSeats == 2 ? 50 :
                                NumOfSeats == 4 ? 100 :
                                NumOfSeats >= 5 ? 150 : 0;

            decimal convertibleCost = IsConvertible ? 50 : 0;

            decimal batteryCost = BatteryCapacity <= 50 ? 50 :
                                  BatteryCapacity <= 75 ? 100 :
                                  BatteryCapacity <= 100 ? 150 : 200;

            return (baseCost + doorsCost + seatsCost + convertibleCost + batteryCost) * 12;
        }

        public override string printVehicleDetails()
        {
            return base.printVehicleDetails() + $", Battery Capacity: {BatteryCapacity} kWh";
        }
    }

}
