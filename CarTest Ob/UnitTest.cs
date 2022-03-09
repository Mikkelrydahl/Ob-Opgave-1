using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorisk_Opgave_3._Sem;
using System;


namespace CarTest_Ob
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IdTestMethod()
        {
            Car car = new Car(1, "BMVV", 1000000, "BMVV123");
            car.Id = 1;
            Assert.IsInstanceOfType(car.Id, typeof(int));
        }

        [TestMethod]
        public void ModelTestMethod()
        {
            Car car = new Car(2, "Audi", 2000000, "Audi123");
            car.Model = "Audi";
            Assert.AreEqual("Audi", car.Model);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Model = "5");
            
        }

        [TestMethod]
        public void PriceTestMethod()
        {
            Car car = new Car(3, "Mercedes", 3000000, "Merce123");
            car.Price = 3000000;
            Assert.AreEqual(3000000, car.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Price = 0);
        }

        [TestMethod()]
        public void LicensePlateTestMethod()
        {
            Car car = new Car(1, "Fiat", 4000000, "Fiat123");
            car.LicensePlate = "Fiat123";
            Assert.AreEqual("Fiat123", car.LicensePlate);
            car.LicensePlate = "AA";
            Assert.AreEqual("AA", car.LicensePlate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "12345678");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "1");
        }
    }
}
