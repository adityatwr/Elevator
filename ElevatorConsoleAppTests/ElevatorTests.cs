using NUnit.Framework;

namespace ElevatorConsoleApp.Tests
{
    [TestFixture]
    public class ElevatorTests
    {
        [Test]
        public void GetCurrentFloor_MoveToFloor_CorrectBehavior()
        {
            Elevator elevator = new Elevator(5);
            elevator.MoveToFloor(4);
            Assert.AreEqual(elevator.CurrentFloor, 4);
        }

        [Test]
        public void GetCurrentCapacity_BoardPassengers_CorrectBehavior()
        {
            Elevator elevator = new Elevator(5);
            elevator.BoardPassengers(4);
            Assert.AreEqual(elevator.CurrentCapacity, 4);
        }

        [Test]
        public void GetText_Direction_CorrectBehavior()
        {
            Elevator elevator = new Elevator(5);
            elevator.GetDirectionText(1);
            Assert.AreEqual(elevator.GetDirectionText(1), "up");
            Assert.AreEqual(elevator.GetDirectionText(-1), "down");
            Assert.AreNotEqual(elevator.GetDirectionText(0), "up");
        }
    }
}