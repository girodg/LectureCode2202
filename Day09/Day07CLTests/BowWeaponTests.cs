using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL.Tests
{
    [TestClass()]
    public class BowWeaponTests
    {
        [TestMethod()]
        public void BowWeaponTest()
        {
            BowWeapon bow = new BowWeapon(10, 20, WeaponRarity.Common, 2, 20, 5);
            Assert.AreEqual(10, bow.ArrowCount);
            Assert.AreEqual(20, bow.ArrowCapacity);
            Assert.AreEqual(WeaponRarity.Common, bow.Rarity);
            Assert.AreEqual(2, bow.Level);
            Assert.AreEqual(20, bow.MaxDamage);
            Assert.AreEqual(5, bow.Cost);
        }
    }
}