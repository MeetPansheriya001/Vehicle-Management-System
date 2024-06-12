# 🚗 Vehicle Management System 🚚

## Summary
This project involves developing a vehicle management system using WPF and C#. The application allows users to manage a collection of vehicles for an imaginary transportation company and calculate their annual insurance costs. The project demonstrates skills in C#, WPF, and object-oriented programming.

## Features
📝 **Abstract Class Vehicle:** Defined a parent class `Vehicle` with common properties and an abstract method to calculate insurance costs.

🚗 **Car Class:**
- Inherits from `Vehicle`.
- Properties: Id, Make, Model, Year of Manufacture, Color, Number of Doors, Number of Seats, Is Convertible.
- Method: Calculate annual insurance cost based on criteria.

⚡ **Electric Car Class:**
- Inherits from `Car`.
- Additional Property: Battery Capacity (in kWh).
- Method: Calculate annual insurance cost with additional criteria.

🚚 **Truck Class:**
- Inherits from `Vehicle`.
- Properties: Id, Make, Model, Year of Manufacture, Color, Number of Axles, Load Capacity (in lbs).
- Method: Calculate annual insurance cost based on criteria.

🔧 **Generic Collection:**
- Maintains a collection of `Vehicle` objects.
- Populates the collection with sample data on program run.

🌐 **User Interface:**
- Designed a dynamic window using layout panels.
- Display vehicle data in a `DataGrid`.
- Implemented functionality to find vehicles by ID and display details dynamically.

❗ **Exception Handling:**
- Ensured no unhandled exceptions at runtime.
- Displayed clear error messages using `MessageBox`.

## Technologies Used
☕ **C#:** Core programming language used for the application.

🖼️ **WPF:** Framework used to create the user interface.

🔄 **Object-Oriented Programming:** Applied OOP principles to design the class hierarchy.

## Instructions
📄 **Abstract Class Definition:**
- Define an abstract class `Vehicle` with common properties and an abstract method for insurance cost calculation.

🚗 **Subclass Implementation:**
- Define classes `Car`, `ElectricCar`, and `Truck` inheriting from `Vehicle`.
- Implement constructors and methods to initialize properties and calculate insurance costs.

🗃️ **Generic Collection Setup:**
- Create a generic collection of type `Vehicle` to store derived class objects.
- Populate the collection with sample data on program run.

🌐 **User Interface Design:**
- Design a window using layout panels like Grid and StackPanel.
- Use data binding to display vehicle data in a `DataGrid`.

❗ **Exception Handling:**
- Implement error handling and validation for user inputs using `MessageBox`.

🚀 **Run the Application:**
- Deploy the application and access the interface to manage vehicles and calculate insurance costs.

## Project Structure
🗃️ **Model:**
- Contains the `Vehicle`, `Car`, `ElectricCar`, and `Truck` classes with their properties and methods.

🔧 **Controller:**
- Manages the interactions between the model and view, including data binding and event handling.

🌐 **View:**
- Contains the XAML templates for the user interface, including layout panels and data binding.
