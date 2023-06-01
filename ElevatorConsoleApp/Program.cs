using ElevatorConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int floorVolume = Utility.GetInputNumber(args[0], 10);
        int elevatorVolume = Utility.GetInputNumber(args[1], 2);
        int capacityVolume = Utility.GetInputNumber(args[2], 10);

        ElevatorSystem elevatorSystem = new ElevatorSystem(floorVolume, elevatorVolume, capacityVolume);

        while (true)
        {
            Console.WriteLine($"Enter the floor number to call the elevator (1-{floorVolume}):");
            string floorInput = Console.ReadLine();

            if (int.TryParse(floorInput, out int floorNumber) && floorNumber >= 1 && floorNumber <= floorVolume)
            {
                elevatorSystem.CallElevator(floorNumber);
            }
            else
            {
                Console.WriteLine("Invalid floor number. Please try again.");
            }

            Console.WriteLine("Press any key to continue or 'q' to quit.");

            if (Console.ReadLine().ToLower() == "q")
            {
                break;
            }
        }
    }
}
