using NUnit.Framework;

namespace ElevatorConsoleApp.Tests
{
    [TestFixture]
    public class UtilityTests
    {
        [Test]
        public void GetInputNumberTest()
        {
            Assert.AreEqual(Utility.GetInputNumber("5",2),5);
            Assert.AreEqual(Utility.GetInputNumber(null, 2), 2);
        }
    }
}