namespace ElevatorConsoleApp
{
    public class Elevator
    {
        public int CurrentFloor { get; private set; }
        public bool IsMoving { get; private set; }
        public int Direction { get; private set; }
        public int Capacity { get; }
        public int CurrentCapacity { get; private set; }

        public Elevator(int capacity)
        {
            CurrentFloor = 1;
            IsMoving = false;
            Direction = 0;
            Capacity = capacity;
            CurrentCapacity = 0;
        }

        public void MoveToFloor(int floorNumber)
        {
            IsMoving = true;
            Direction = floorNumber > CurrentFloor ? 1 : -1;

            Console.WriteLine($"Elevator is moving {GetDirectionText(Direction)} from floor {CurrentFloor} to floor {floorNumber}.");

            while (CurrentFloor != floorNumber)
            {
                CurrentFloor += Direction;
                Console.WriteLine($"Elevator is passing floor {CurrentFloor}.");
            }

            IsMoving = false;
            Direction = 0;

            Console.WriteLine($"Elevator has arrived at floor {CurrentFloor}.");
        }

        public void BoardPassengers(int numberOfPeople)
        {
            if (CurrentCapacity + numberOfPeople <= Capacity)
            {
                CurrentCapacity += numberOfPeople;
                Console.WriteLine($"Boarded {numberOfPeople} people. Current capacity: {CurrentCapacity}.");
            }
            else
            {
                Console.WriteLine($"Cannot board {numberOfPeople} people. Exceeds capacity.");
            }
        }

        public void DisembarkPassengers(int numberOfPeople)
        {
            if (CurrentCapacity - numberOfPeople >= 0)
            {
                CurrentCapacity -= numberOfPeople;
                Console.WriteLine($"Disembarked {numberOfPeople} people. Current capacity: {CurrentCapacity}.");
            }
            else
            {
                Console.WriteLine($"Cannot disembark {numberOfPeople} people. Current capacity is {CurrentCapacity}.");
            }
        }

        public string GetDirectionText(int direction)
        {
            if (direction == 1)
                return "up";
            else if (direction == -1)
                return "down";
            else
                return "nowhere";
        }
    }


}
