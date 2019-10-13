using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestRR
{
    [TestClass]
    public class UnitTest1
    {
        RussianRoulete.ShootingClass shootingClass = new RussianRoulete.ShootingClass();

        [TestMethod]
        public void TestMethod1()
        {
            int result = shootingClass.SpinChamber();

            Assert.IsTrue(result > 0 && result < 7);
        }
    }
}
