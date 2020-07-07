using System;
using System.Collections.Generic;
using System.Text;

namespace RiLiao.Utility
{
    public class DrinksTurnOver
    {
        public int Id
        {
            get; set;
        }
        public double Amount
        {
            get; set;
        }

        public double Discount
        {
            get; set;
        }

        public int TurnOverType
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public Guid OnwerId
        {
            get; set;
        }
        public string Owner
        {
            get; set;
        }
        public int WeekDay
        {
            get; set;
        }
        public DateTime CreateTime
        {
            get; set;
        }
    }
}
