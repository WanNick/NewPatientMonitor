using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewPatientMonitor;

namespace NewPatientMonitorTest
{
    [TestClass]
    public class TestAlarmTester
    {
        // ARRANGE
        AlarmTester alarmTesterCreated;

        // ACT
        [TestInitialize]
        public void setup()
        {
             alarmTesterCreated = new AlarmTester("Module Name", 12f, 54f);
            // alarmTesterCreated = new AlarmTester("Module Name", 0f, 0f);
        }

        // ASSERT
       
        [TestMethod]
        public void IsAlarmTestGoodCreation()
        {
            Assert.AreEqual("Module Name", alarmTesterCreated.NameOfAlarm);
            Assert.AreEqual(12f, alarmTesterCreated.LowerLimit);
            Assert.AreEqual(54f, alarmTesterCreated.UpperLimit);
        }

        [TestMethod]
        public void IsAlarmWithinLimits()
        {
            Assert.IsFalse(alarmTesterCreated.ValueOutsideLimits (13f));
            Assert.IsFalse(alarmTesterCreated.ValueOutsideLimits (53f));
            Assert.IsFalse(alarmTesterCreated.ValueOutsideLimits(41f));
        
        }

        [TestMethod]
        public void IsAlarmOutsideLimits()
        {
            Assert.IsTrue(alarmTesterCreated.ValueOutsideLimits(11f));
            Assert.IsTrue(alarmTesterCreated.ValueOutsideLimits(9f));
            Assert.IsTrue(alarmTesterCreated.ValueOutsideLimits(65f));
        }

        [TestMethod]
        public void  AlarmDropsToZero() 
        {
            // Do we need to check whether the values drop to zero.

            Assert.IsFalse(alarmTesterCreated.ValueOutsideLimits (0f));
            Assert.IsFalse(alarmTesterCreated.ValueOutsideLimits(0f));
            Assert.IsFalse(alarmTesterCreated.ValueOutsideLimits(0f));

            /*Assert.IsTrue(alarmTesterCreated.ValueOutsideLimits(0f));
            Assert.IsTrue(alarmTesterCreated.ValueOutsideLimits(0f));
            Assert.IsTrue(alarmTesterCreated.ValueOutsideLimits(0f));*/
        }

        
    }
}
