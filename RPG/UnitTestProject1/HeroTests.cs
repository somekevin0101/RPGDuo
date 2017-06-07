using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Classes;
using RPG.Classes.CasinoGames;
using RPG.Classes.HeroClasses;

namespace UnitTestProject1
{
    [TestClass]
    public class HeroTests
    {
        [TestMethod]
        public void ChangeMoneyTest()
        {
            Knight testKnight = new Knight("bob");

            testKnight.ChangeMoney(-30);
            Assert.AreEqual(-5, testKnight.Money);

            testKnight.ChangeMoney(10);
            Assert.AreEqual(5, testKnight.Money);
        }
        
        [TestMethod]
        public void ChangeReputationTest()
        {
            Knight testKnight = new Knight("bob");

            testKnight.ChangeReputation(-15);
            Assert.AreEqual(0, testKnight.Reputation);

            testKnight.ChangeReputation(50);
            Assert.AreEqual(50, testKnight.Reputation);

        }

        [TestMethod]
        public void ChangeHitPointsTest()
        {
            Archer testArcher = new Archer("william");

            testArcher.ChangeHitPoints(-50);
            Assert.AreEqual(60, testArcher.CurrentHitPoints);

            testArcher.ChangeHitPoints(25);
            Assert.AreEqual(85, testArcher.CurrentHitPoints);
        }

        [TestMethod]
        public void RestTest()
        {
            Barbarian testBarbarian = new Barbarian("bob");

            testBarbarian.DrinkBeer(20);
            testBarbarian.ChangeHitPoints(-50);
            testBarbarian.Rest();

            Assert.AreEqual(125, testBarbarian.CurrentHitPoints);
            Assert.AreEqual(15, testBarbarian.Endurance);
            Assert.AreEqual(13, testBarbarian.Strength);
        }

    }
}
