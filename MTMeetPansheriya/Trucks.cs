using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMeetPansheriya
{
    public class Truck : Vehicle
    {
        public int NumOfAxles { get; set; }
        public int LoadCapacitylbs { get; set; }

        public Truck(string id, string make, string model, int yearOfManufacture, string color, int numberOfAxles, int loadCapacity)
            : base(id, make, model, yearOfManufacture, color)
        {
            NumOfAxles = numberOfAxles;
            LoadCapacitylbs = loadCapacity;
        }



        public override decimal AnnualInsuranceCost()
        {
            decimal baseCost = YearOfManufacture >= 2010 ? 200 :
                              YearOfManufacture >= 2000 && YearOfManufacture <= 2009 ? 400 :
                              YearOfManufacture >= 1990 && YearOfManufacture <= 1999 ? 800 : 1000;

            decimal axlesCost = NumOfAxles == 2 ? 50 :
                                NumOfAxles == 4 ? 100 :
                                NumOfAxles >= 5 ? 150 : 0;

            decimal loadCapacityCost = LoadCapacitylbs <= 1000 ? 50 :
                                       LoadCapacitylbs <= 2000 ? 100 :
                                       LoadCapacitylbs <= 3000 ? 150 : 200;

            return (baseCost + axlesCost + loadCapacityCost) * 12;
        }

        public override string printVehicleDetails()
        {
            return $"ID: {Id}   , Make: {Make}   , Model: {Model}   , Year: {YearOfManufacture}   , Color: {Color}   , Number of Axles: {NumOfAxles}  , Load Capacity: {LoadCapacitylbs} lbs";
        }
    }
}
