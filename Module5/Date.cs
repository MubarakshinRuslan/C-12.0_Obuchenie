using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    public class Date
    {
        private int year;
        public int Year 
        {
            get => year;
            set
            {
                if(value > 0 && value < 10000)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("invalid year");
                }
            } 
        }
        private int month;
        public int Month 
        { 
            get => month;
            set
            {
                if(value > 0 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("invalid month");
                }
            } 
        }
        private int day;
        public int Day 
        { 
            get => day;
            set 
            { 
                switch(Month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if(value > 0 && value <= 31)
                        {
                            day = value;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("invalid day");
                        }
                        break;
                    case 2:
                        if(Year % 4 == 0 && Year % 100 != 0)
                        {
                            if (value > 0 && value <= 29)
                            {
                                day = value;
                            }
                            else
                            {
                                throw new ArgumentOutOfRangeException("invalid day");
                            }
                        }
                        else
                        {
                            if (value > 0 && value <= 28)
                            {
                                day = value;
                            }
                            else
                            {
                                throw new ArgumentOutOfRangeException("invalid day");
                            }
                        }
                        break;
                    default:
                        if (value > 0 && value <= 30)
                        {
                            day = value;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("invalid day");
                        }
                        break;
                }
            } 
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date() :
            this(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        {

        }

    }
}
