using DiaasCarApp;

namespace Metodetests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                // Arrange
                var car = new ElectricCar("Tesla", "Model S", "ABC123", 100, 5);
                car.StartEngine();
                car.Charge(50);
                // Act
                car.Drive(100);
                // Assert
                Assert.AreEqual(30, car._currentCharge);
                Assert.AreEqual(100, car.Odometer);
            }
        }
            [TestMethod]
        public void TestMethod2()
        {


            {
                // Arrange
                var car = new FuelCar("Seat", "Arona", "BE25546", 45, 19);
                car.StartEngine();
                car.refuel(40);
                // Act
                car.Drive(57);
                // Assert
                Assert.AreEqual(37, car.CurrentFuel);
                Assert.AreEqual(57, car.Odometer);

            }
        }
    
    }
}
