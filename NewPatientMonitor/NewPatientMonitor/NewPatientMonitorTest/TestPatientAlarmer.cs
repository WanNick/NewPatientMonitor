using System;
using Moq; // Installed the Moq testing from nuget packages
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewPatientMonitor; //This Using line was added because it will use the NewPatientMonitor


namespace TestMethodPMS
{
    [TestClass]
    public class TestPatientAlarmer
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

            var patientData = new Mock<IPatientData>();

            // This uses the Lambda expresssions (=>)
            // From the left we have our arguments, the result however is on the right.
            patientData.Setup(a => a.BreathingRate).Returns (15f);
            patientData.Setup(b => b.DiastolicRate).Returns(74f);
            patientData.Setup(c => c.PulseRate).Returns(60f);
            patientData.Setup(d => d.SystolicRate).Returns(125f);
            patientData.Setup(e => e.TemperatureRate).Returns(38f);

            // The code above checks to see if no events are called

            var breathingRateAlarmWasCalled = false;
            var diastolicRateAlarmWasCalled = false;
            var pulseRateAlarmWasCalled = false;
            var systolicAlarmWasCalled = false;
            var temperatureRateAlarmWasCalled = false;



            patientAlarmer.breathingrateAlarm += (sender, e) => pulseRateAlarmWasCalled = true;

            // ACT


            // ASSERT


        }
    }
}
