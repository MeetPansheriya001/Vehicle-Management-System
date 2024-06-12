using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using static System.Net.Mime.MediaTypeNames;

namespace MTMeetPansheriya
{
    public partial class MainWindow : Window
    {
        private List<Vehicle> vehicles;

        public MainWindow()
        {
            InitializeComponent();

            vehicles = new List<Vehicle>
            {
                new Car("1", "Toyota", "Camry", 2012, "Blue", 4, 5, false),
                new Car("2", "Honda", "Civic", 2005 , "Silver", 4, 5, false),
                new Car("3", "Ford", "Mustang", 2023, "Red", 4, 5, true),
                new ElectricCar("4", "Tesla", "Model S", 2018, "Black", 4, 5, false, 75),
                new ElectricCar("5", "Chevrolet", "Bolt", 2020, "White", 4, 5, false, 75),
                new ElectricCar("6", "Nissan", "Leaf", 2022, "Red", 4, 5, true, 75),
                new Truck("7", "Ford", "F-150", 2015, "Black", 2, 2000),
                new Truck("8", "Dodge", "1500", 2021, "White", 2, 2300),
                new Truck("9", "Chevrolet", "Silverado", 2007, "Red", 2, 1800)
            };

            VehicleIdTextBox.TextChanged += VehicleIdTextBox_TextChanged;
             CarRadioButton.Checked +=   VehicleTypeRadioButton_Checked;

              ElectricCarRadioButton.Checked += VehicleTypeRadioButton_Checked;
             TruckRadioButton.Checked += VehicleTypeRadioButton_Checked;
             FindButton.Click += FindButton_Click;

        }


        private void VehicleIdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FindButton.IsEnabled = !string.IsNullOrEmpty(VehicleIdTextBox.Text);
        }

        private void VehicleTypeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();


        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            string vehicleId = VehicleIdTextBox.Text;
            Vehicle foundVehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId);

            if (foundVehicle != null)
            {
                
                PopulateLabels( foundVehicle );

                MakeTextBox.Text = foundVehicle.Make;
                ModelTextBox.Text = foundVehicle.Model;
                YearTextBox.Text = foundVehicle.YearOfManufacture.ToString();
                ColorTextBox.Text = foundVehicle.Color;
                InsuranceCostTextBox.Text = foundVehicle.AnnualInsuranceCost().ToString();



                if (foundVehicle is Car car)
                {
                    NumberOfDoorsTextBox.Text = car.NumOfDoors.ToString();
                }
                else if (foundVehicle is Truck truck)
                {
                    NumberOfDoorsTextBox.Text = truck.NumOfAxles.ToString();
                }
                else
                {
                    NumberOfDoorsTextBox.Text = "";
                }



                if (foundVehicle is Car car1)
                {
                    NumberOfSeatsTextBox.Text = car1.NumOfSeats.ToString();
                }
                else
                {
                    NumberOfSeatsTextBox.Text = "";
                }

                if (foundVehicle is ElectricCar electricCar)
                {
                    BatteryCapacityTextBox.Text = electricCar.BatteryCapacity.ToString();
                }
                else
                {
                    BatteryCapacityTextBox.Text = "";
                }


            }
            else
            {
                MessageBox.Show("please, enter valid vehicle id !!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                ClearLabels();
            }
        }




        public void RefreshDataGrid()
        {
            if (CarRadioButton.IsChecked == true)
            {
                DataGrid.ItemsSource = vehicles.OfType<Car>().ToList();
            }
            else if (ElectricCarRadioButton.IsChecked == true)
            {
                DataGrid.ItemsSource = vehicles.OfType<ElectricCar>().ToList();
            }
            else if (TruckRadioButton.IsChecked == true)
            {
                DataGrid.ItemsSource = vehicles.OfType<Truck>().ToList();
            }
        }

        private void PopulateLabels(Vehicle vehicle)
        {
            
            if (vehicle is Car car)
            {
                BatteryCapacityLabel.Visibility = Visibility.Hidden;
                BatteryCapacityTextBox.Visibility = Visibility.Hidden;
                NumberOfDoorsLabel.Content = "Number of Doors:";
                NumberOfSeatsLabel.Content = "Number of Seats:";
                ConvertibleCheckBox.Visibility = Visibility.Visible;
                ConvertibleCheckBox.IsChecked = car.IsConvertible;

            }
            else if (vehicle is ElectricCar electricCar)
            {
                BatteryCapacityLabel.Visibility = Visibility.Visible;
                BatteryCapacityTextBox.Visibility = Visibility.Visible;
                BatteryCapacityLabel.Content = $"Battery Capacity: {electricCar.BatteryCapacity} kWh";
                ConvertibleCheckBox.Visibility = Visibility.Visible;
                ConvertibleCheckBox.IsChecked = electricCar.IsConvertible;
            }
          
            else if (vehicle is Truck truck)
            {
                BatteryCapacityLabel.Visibility = Visibility.Hidden;
                BatteryCapacityTextBox.Visibility = Visibility.Hidden;
                NumberOfSeatsLabel.Visibility = Visibility.Hidden;
                NumberOfSeatsTextBox.Visibility = Visibility.Hidden;
                ConvertibleCheckBox.Visibility = Visibility.Hidden;

            }
        }

        private void ClearLabels()
        {
            
            BatteryCapacityLabel.Content = string.Empty;
            NumberOfDoorsLabel.Content = string.Empty;
            NumberOfSeatsLabel.Content = string.Empty;
            ConvertibleCheckBox.IsChecked = false;
        }
    }
}