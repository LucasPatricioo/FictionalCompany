﻿using System;

namespace FictionalCompany.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHours, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHours;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}