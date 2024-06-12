using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMeetPansheriya
{
    public class Car : Vehicle
    {
        public int NumOfDoors { get; set; }
        public int NumOfSeats { get; set; }
        public bool IsConvertible { get; set; }

        public Car(string id, string make, string model, int yearOfManufacture, string color, int numOfDoors, int numOfSeats, bool isConvertible)
            : base(id, make, model, yearOfManufacture, color)
        {
            NumOfDoors = numOfDoors;
            NumOfSeats = numOfSeats;
            IsConvertible = isConvertible;
        }

        public override decimal AnnualInsuranceCost()
        {
            decimal YearManuCost = YearOfManufacture >= 2010 ? 100 :
                              YearOfManufacture >= 2000 && YearOfManufacture <= 2009 ? 200 :
                              YearOfManufacture >= 1990 && YearOfManufacture <= 1999 ? 300 : 400;

            decimal NumdoorsCost = NumOfDoors == 2 ? 50 :
                                NumOfDoors == 4 ? 100 :
                                NumOfDoors >= 5 ? 150 : 0;

            decimal NumseatsCost = NumOfSeats == 2 ? 50 :
                                NumOfSeats == 4 ? 100 :
                                NumOfSeats >= 5 ? 150 : 0;

            decimal IsconvertibleCost = IsConvertible ? 100 : 0;

            return (YearManuCost + NumdoorsCost + NumseatsCost + IsconvertibleCost) * 12;
        }

        public override string printVehicleDetails()
        {
            return $"ID: {Id}   , Make: {Make}   , Model: {Model}   , Year: {YearOfManufacture}   , Color: {Color}   , Number of Doors: {NumOfDoors}   , Number of Seats: {NumOfSeats}   , Is Convertible: {(IsConvertible ? "Yes" : "No")}";
        }
    }

}
