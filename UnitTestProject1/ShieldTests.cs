using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperStarTrek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperStarTrekTest
{
    [TestClass]
    public class ShieldTests
    {
       Shield shield;

       public ShieldTests()
        {
            shield = new Shield();
        }

        [TestMethod]
        public void ShieldsDownByDefault()
        {
            Assert.IsFalse(shield.IsUp());
        }

        [TestMethod]
        public void TestRaiseShields()
        {
            shield.RaiseShield();
            Assert.IsTrue(shield.IsUp());
        }

        [TestMethod]
        public void ShieldDefaultEnergy()
        {
            Assert.AreEqual(8000, shield.GetCurrrentEnergy());
        }

        [TestMethod]
        public void TransferShieldEnergy()
        {
            shield.TransferEnergy(2000);
            Assert.AreEqual(10000, shield.GetCurrrentEnergy());
        }

        [TestMethod]
        public void TestMaximumShieldPower()
        {
            shield.TransferEnergy(2001);
            Assert.AreEqual(shield.maxPower, shield.GetCurrrentEnergy());
        }

        [TestMethod]
        public void TestMinimumShieldPower()
        {
            shield.TransferEnergy(-8001);
            Assert.AreEqual(0, shield.GetCurrrentEnergy());
        }

        
    }
}
