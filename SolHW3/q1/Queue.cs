using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Queue
    {
        Trip[] trips;
        int index = 0;

        public Queue()
        {
            trips = new Trip[1];
            index++;
        }

        public bool IsEmpty()
        {
            return index == 0;
        }
        public void Enqueue(Trip t)
        {
            bool flag = false;
            for (int i = 0; i < this.trips.Length; i++)
            {
                if (this.trips[i].CompareDate(t) == 0 && this.trips[i].Typetrip == t.Typetrip)
                {
                    Console.WriteLine("There's already a trip which occurs on that date and has the same type of trip");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                trips[index++] = t;
            }
        }

        public Trip Dequeue()
        {
            Trip temp = new Trip();
            if (!IsEmpty())
            {
                temp = this.trips[0];
                index--;
                for (int i = 0; i < index; i++)
                {
                    trips[i] = trips[i + 1];
                }
                return temp;
            }
            else
            {
                Console.WriteLine("Empty");
                return null;
            }
        }
        public int SearchTripByNum(int tripnum)
        {
            int index = -1;
            Trip[] temp = new Trip[this.index + 1];
            for (int i = 0; i < trips.Length; i++)
            {
                temp[i] = Dequeue();
                if (temp[i].TripNum1 == tripnum)
                {
                    index = i;
                }              
            }
            for (int i = trips.Length-1; i >= 0; i--)
            {
                Enqueue(temp[i]);
            }
            return index;
        }

        public Trip[] SearchTripByType(TripType t)
        {          
            
            Trip[] temp = new Trip[this.index + 1];
            int counter = 0;
            if (!IsEmpty())
            {
                for (int i=0; i <trips.Length; i++)
                {
                    temp[i] = Dequeue();
                    if (temp[i].Typetrip==t)
                    {
                        counter++;
                    }
                }
                if (counter!=0)
                {
                    for (int i = trips.Length - 1; i >= 0; i--)
                    {
                        Enqueue(temp[i]);
                    }
                    Trip[] typeArr = new Trip[counter];
                    for (int i = 0; i < this.trips.Length; i++)
                    {
                        if (temp[i].Typetrip == t)
                        {
                            typeArr[i] = temp[i];
                        }
                    }
                }
                else
                {
                    return null;
                }                            
            }
            Console.WriteLine("Empty");
            return null;
        }

        public void PrintQueue()
        {
            foreach (Trip item in trips)
            {
                item.PrintTrip();
            }
        }

        public void deleteTrip(int tripnum)
        {
            int index=0;
            Trip[] temp = new Trip();
            for (int i = 0; i < this.trips.Length; i++)
            {
                temp[i] = Dequeue();
                if (temp[i].TripNum1==tripnum)
                {
                    index = i;
                    break;
                }
            }
            for (int i = this.trips.Length-1; i >= 0; i--)
            {
                if (i==index)
                {
                    Enqueue(temp[i]);
                }
                
            }
        }
    }
}

