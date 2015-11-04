using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewPatientMonitor;

/*
 *  Unit tests for the module class
*/ 

namespace NewPatientMonitorTest
{
    [TestClass]
    public class Module_Tester
    {
        [TestMethod]
        public void DefaultModuleCreated()
        {
            Module testModule = new Module();

            Assert.AreEqual(testModule.Name, NewPatientMonitor.DefaultSettings.NEW_MODULE_NAME);
            Assert.AreEqual(testModule.LowerLimit, NewPatientMonitor.DefaultSettings.LOWER_DEFAULT_VALUE);
            Assert.AreEqual(testModule.UpperLimit, NewPatientMonitor.DefaultSettings.UPPER_DEFAULT_VALUE);

            // This is a test comment.
        }
    }
}
