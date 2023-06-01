using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ElevatorConsoleApp.Tests
{
    [TestFixture]
    public class ElevatorSystemTests
    {
        [Test]
        public void CallElevator_ElevatorMovesToFloor_Capacity_CorrectBehavior()
        {
            ElevatorSystem elevatorSystem = new ElevatorSystem(10, 1, 10);
            elevatorSystem.SetPeopleWaitingOnFloor(5, 3);

            elevatorSystem.CallElevator(5);
            Assert.AreEqual(elevatorSystem.floors[5 - 1].PeopleWaiting, 0);
        }

        [Test]
        public void SetPeopleWaitingOnFloor_NumberOfPeopleSet_CorrectBehavior()
        {

            ElevatorSystem elevatorSystem = new ElevatorSystem(10, 2, 5);

            elevatorSystem.SetPeopleWaitingOnFloor(3, 4);

            Assert.AreEqual(elevatorSystem.floors[3 - 1]?.PeopleWaiting, 4);
            Assert.AreEqual(elevatorSystem.floors[0]?.PeopleWaiting, 0);
        }

        [Test]
        public void Find_NearestElevator_CorrectBehavior()
        {
            ElevatorSystem elevatorSystem = new ElevatorSystem(10, 1, 10);
            elevatorSystem.CallElevator(5);
            var elevator = elevatorSystem.GetNearestElevator(6);

            Assert.AreEqual(elevator.CurrentFloor, 5);
        }
    }
}
