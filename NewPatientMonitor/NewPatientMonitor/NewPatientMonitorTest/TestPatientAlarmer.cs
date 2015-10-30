using System;
using Moq; // Installed the Moq testing from nuget packages
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewPatientMonitor; //This Using line was added because it will use the NewPatientMonitor


namespace TestMethodPMS
{
    [TestClass]
    public class TestPatientMonitorAlarmer
    {
        PatientAlarmer patientAlarmer;

        [TestInitialize]
        public void setup ()
        {
            patientAlarmer = new PatientAlarmer();
        }


        [TestMethod]
        public void IfNoEventsCalled()
        {
            // ARRANGE
            // var patientData = new Mock<IPatientdata>();
            // patientData.Setup (a => a)
            

            // ACT


            // ASSERT
            

        }
    }
}
