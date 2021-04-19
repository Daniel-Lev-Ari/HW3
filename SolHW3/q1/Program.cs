using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    enum TripType {Holiday=1, BicycleTrip, FamilyTrip, SeniorsTrip, WineryTrip, Sails, SafariAndDiving}
    class Program
    {
        static void Main(string[] args)
        {
            string dest;
            TripType type1;
            DateTime date;
            int num;
            int choice = int.Parse(Console.ReadLine());
            Queue q1 = new Queue();
            do
            {
                switch (choice)
                {
                    case 1:
                        dest = Console.ReadLine();
                        type1 = (TripType)Convert.ToInt32(Console.ReadLine());
                        date = DateTime.Parse(Console.ReadLine());
                        Trip t1 = new Trip(dest, date, type1);
                        q1.Enqueue(t1);
                        break;
                    case 2:
                        num = int.Parse(Console.ReadLine());
                        q1.Dequeue()
                    default:
                        break;
                }

            } while (choice!=5);

        }
    }
}
