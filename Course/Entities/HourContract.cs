using System;

namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { set; get; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
