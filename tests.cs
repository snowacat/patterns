using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using RusWizards;

namespace Awesome_Tests
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void TestFactory()
        {
            Factory factory = new Factory();
            var GlaxyS = factory.Pipeline.CreateSmartphone(Battery.MAH_4500, Screen.TOUCH_CAPACITIVE, RusWizards.OperatingSystem.ANDROID);            
            var batteryMah = Battery.MAH_4500;

            Assert.AreEqual(batteryMah, GlaxyS.TypeBattery); 
        }
    }
}
