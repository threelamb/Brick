using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IoC.Tests.Entity;

namespace IoC.Tests
{
    [TestClass]
    public class IoCTests
    {
        [TestMethod]
        public void Get()
        {
            IoC.Initialize();
            var warrior = IoC.New<IWarrior>();
            Assert.IsNotNull(warrior);
            Assert.IsNotNull(warrior.Weapon);
        }
    }
}
