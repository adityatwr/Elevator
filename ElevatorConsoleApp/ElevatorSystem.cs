using ElevatorConsoleApp;

public class ElevatorSystem
{
    public List<Floor> floors;
    public List<Elevator> elevators;

    public ElevatorSystem(int numberOfFloors, int numberOfElevators, int elevatorCapacity)
    {
        floors = new List<Floor>();
        for (int i = 1; i <= numberOfFloors; i++)
        {
            floors.Add(new Floor(i));
        }

        elevators = new List<Elevator>();
        for (int i = 0; i < numberOfElevators; i++)
        {
            elevators.Add(new Elevator(elevatorCapacity));
        }
    }

    public void CallElevator(int floorNumber)
    {
        Elevator nearestElevator = GetNearestElevator(floorNumber);
        nearestElevator.MoveToFloor(floorNumber);
        nearestElevator.DisembarkPassengers(floors[floorNumber - 1].PeopleWaiting);
        nearestElevator.BoardPassengers(floors[floorNumber - 1].PeopleWaiting);
        floors[floorNumber - 1].PeopleWaiting = 0;
    }

    public void SetPeopleWaitingOnFloor(int floorNumber, int numberOfPeople)
    {
        floors[floorNumber - 1].PeopleWaiting = numberOfPeople;
    }

    public Elevator GetNearestElevator(int floorNumber)
    {
        Elevator nearestElevator = null;
        int minDistance = int.MaxValue;

        foreach (Elevator elevator in elevators)
        {
            int distance = Math.Abs(elevator.CurrentFloor - floorNumber);
            if (!elevator.IsMoving && distance < minDistance)
            {
                nearestElevator = elevator;
                minDistance = distance;
            }
        }

        return nearestElevator;
    }
}
