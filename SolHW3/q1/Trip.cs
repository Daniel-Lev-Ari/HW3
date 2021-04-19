using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Trip
    {
        static int counter = 0;
        TripType typetrip;
        static uint TripNum = 0;
        string destination;
        DateTime date;

        public uint TripNum1
        {
            get => TripNum;
        }

        public string Destination
        {
            get => destination;
            set
            {
                bool HasInt = value.Any(char.IsDigit); //Boolean variable which gets a "true" statement if the dest string has any digits.
                if (HasInt == true)
                {
                    this.destination = "Null";
                }
                else
                {
                    this.destination = value;
                }
            }
        }
        public int CompareDate(Trip t)
        {
            if (CalcDateTime.DateDif(t.date,DateTime.Now)>0)
            {
                return 1;
            }
            else if (CalcDateTime.DateDif(t.date, DateTime.Now) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public Trip(string destination, DateTime date, TripType t)
        {
            counter++;
            TripNum++;
            Date = date;
            Destination = destination;
            Typetrip = t;

        }

        public Trip()
        {
            TripNum++;
            destination = "Israel";
            date = DateTime.Now;
            Typetrip = TripType.Holiday;
        }
        
        public DateTime Date 
        {
            get => date;
            set
            {
                if (DateTime.Compare(value,DateTime.Now)>=0)
                {
                    date = value;
                }
                else
                {
                    date = new DateTime(2000, 1, 1);
                }
            }
        }

        public TripType Typetrip
        {
            get => typetrip;
            set => typetrip = value;
        }
        public static int Counter
        {
            get => counter;
        }

        public void PrintTrip()
        {
            Console.WriteLine("Trip Number: " + TripNum);
            Console.WriteLine("Trip's destination: " + destination);
            Console.WriteLine("Date: " + date);
            Console.WriteLine("Trip's type: " + Typetrip);
        }
        ~Trip()
        {
            Console.WriteLine("Trip number: " + TripNum + " has been removed");
            counter--;
        }
        public DateTime TripsEnd(uint days)
        {
            return CalcDateTime.AddDayToDate(this.date, days);
        }
       

        
    }
}
    
    
    
    

        

