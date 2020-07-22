﻿using System;

namespace FictionalCompany.Entities.Enums
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue() {
            return ValuePerHour * Hours;
        }
    }
}
