using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    enum TypeTrip {Holiday=1, BicycleTrip, FamilyTrip, SeniorsTrip, WineryTrip, Sails, SafariAndDiving}
    class Program
    {
        static void Main(string[] args)
        {
            string dest;
            TypeTrip typeoft;
            DateTime date;
            int num,choice;
            Queue q1 = new Queue();
            string menu = "\n1. Add Trip to queue\n"+"2. Delete Trip\n"+"3. Print All Trips\n"+"4. Search and print vacation trip\n"+"5. Quit\n";
         
            do
            {
                Console.WriteLine(menu);
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the dastination of the trip");
                        dest = Console.ReadLine();
                        Console.WriteLine("Enter the type of trip: ");
                        foreach(string item in Enum.GetNames(typeof(TypeTrip)))
                        {
                            Console.WriteLine(item);
                           
                        }
                        Console.WriteLine();
                        typeoft = (TypeTrip)Enum.Parse(typeof(TypeTrip),Console.ReadLine());
                        Console.WriteLine("Enter the date of trip");
                        date = DateTime.Parse(Console.ReadLine());
                        Trip t1 = new Trip(dest, date,typeoft);
                        q1.Enqueue(t1);
                        break;
                    case 2:
                        Console.WriteLine("Enter num of trip");
                        num = int.Parse(Console.ReadLine());
                        q1.Dequeue();
                        break;
                    case 3:
                        if (!q1.IsEmpty())
                        {
                            q1.PrintQueue();
                        }
                        else
                        {
                            Console.WriteLine("The queue is empty!");
                        }
                        break;

                    case 4:

                        Trip[] temp=new Trip[5];
                        temp=q1.SearchTripByType((TypeTrip)Enum.Parse(typeof(TypeTrip),"1"));
                    
                        int days;
                        if (temp != null)
                        {
                            for (int i = 0; i < temp.Length; i++)
                            {
                                Console.WriteLine("Enter amount of days");
                                days = int.Parse(Console.ReadLine());
                                temp[i].PrintTrip();
                                Console.WriteLine("End of Trip: ");
                                temp[i].TripsEnd((uint)days);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no holidays trip");
                        }
                       
                        
                        break;
                    case 5:
                        choice = '5';
                        break;
                }

            } while (choice!=5);

        }
    }
}
