# Elevator Simulation Console Application

This console application simulates the movement of elevators in a building, with the goal of efficiently transporting people between floors. The application allows you to interact with the elevators by calling them to a specific floor and setting the number of people waiting on each floor.

The Elevator Simulation Console Application is implemented in C# .Net 6.0.

# Features
* Multiple floors: The application supports multiple floors in the building.
* Multiple elevators: The application can simulate the movement of multiple elevators.
* Elevator status: The application displays the status of each elevator, including the current floor, whether it is moving and in which direction, and the number of people it is carrying.
* Calling elevators: Users can call an elevator to a specific floor.
* People waiting: Users can set the number of people waiting on each floor.
* Weight limit: The elevators have a weight limit (expressed as a number of people), and the application checks and handles boarding and disembarking of passengers based on the weight limit.

# Usage
* Build the solution using an appropriate C# development environment.
* Run the application, and the console will prompt you to enter the floor number to call the elevator.
* Enter a valid floor number between 1 and the total number of floors in the building.
* The elevator will move to the selected floor, and the application will display the status and actions of the elevator.
* You can continue calling the elevator to different floors or quit the application by pressing 'q'.

# Unit Tests
The solution includes unit tests implemented using the NUnit framework. The tests cover the functionality of the ElevatorSystem, Elevator and Utility class and the associated methods. To run the unit tests:

# Input parameters for console app
There are three input parameter like as example. [10 2 14]
| SN  |  Name					   |      Type       | Description                            |  Example             |
|:----|:----------------:|:---------------:|:---------------------------------------|:--------------------:|
|1    | floor		  	     | Integer         | Number of floor we want to cover       | 10  		             |
|2    | elevator         | Integer         | Number of elevator installed           | 2                    |
|3    | capacity			   | Integer         | Given capacity                         | 14                   |



