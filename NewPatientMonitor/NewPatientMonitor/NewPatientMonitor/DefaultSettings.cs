﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPatientMonitor
{
    // This is the default settings or values for the Patient Monitor Program.
    public struct DefaultSettings
    {
        public const float UPPER_BREATHING_RATE = 19f;
        public const float LOWER_BREATHING_RATE = 12f;
        public const float UPPER_DIASTOLIC_RATE = 95f;
        public const float LOWER_DIASTOLIC_RATE = 70f;
        public const float UPPER_PULSE_RATE = 80f;
        public const float LOWER_PULSE_RATE = 55f;
        public const float UPPER_SYSTOLIC_RATE = 140;
        public const float LOWER_SYSTOLIC_RATE = 120;
        public const float UPPER_TEMPERATURE_RATE = 38.5f;
        public const float LOWER_TEMPERATURE_RATE = 35.5f;
    }
}
